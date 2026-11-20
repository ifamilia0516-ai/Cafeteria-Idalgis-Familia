using System;
using System.Globalization;
using System.Windows.Forms;

namespace Examen_Cafeteria_SuNombre
{
    public partial class frmPedidos : Form
    {
        // Constantes de reglas de negocio (RD$)
        private const decimal RECARGO_GRANDE = 25m;
        private const decimal RECARGO_PORCION_EXTRA = 30m;
        private const decimal PORCENTAJE_DESCUENTO = 0.10m;
        private const decimal COSTO_EMPAQUE = 20m;
        private const decimal TASA_ITBIS = 0.18m;

        // Anchos de columnas para Encabezado y ListBox (6, 24, 10 y 12)
        private const int ANCHO_CANT = 6;
        private const int ANCHO_PROD = 24;
        private const int ANCHO_PRECIO = 10;
        private const int ANCHO_TOTAL = 12;

        // Acumulador de subtotal del pedido
        private decimal subtotalPedido = 0m;

        public frmPedidos()
        {
            InitializeComponent();
        }

        // Evento Load: dejar controles y resultados en valores iniciales y encabezado formateado
        private void frmPedidos_Load(object sender, EventArgs e)
        {
            InicializarFormulario();
        }

        // Evento Agregar al pedido
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProducto.Text))
            {
                MessageBox.Show("Debe digitar el nombre del producto.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProducto.Focus();
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text.Trim(), NumberStyles.Number, CultureInfo.CurrentCulture, out decimal precioDigitado) &&
                !decimal.TryParse(txtPrecio.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out precioDigitado))
            {
                MessageBox.Show("Digite un precio válido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return;
            }

            if (precioDigitado <= 0)
            {
                MessageBox.Show("El precio debe ser mayor que cero.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return;
            }

            int cantidad = (int)nudCantidad.Value;

            // Regla 1: Precio unitario = precio digitado + 25 si es grande + 30 si lleva porción extra
            decimal precioUnitario = precioDigitado;
            if (rbtGrande.Checked)
            {
                precioUnitario += RECARGO_GRANDE;
            }
            if (chkPorcionExtra.Checked)
            {
                precioUnitario += RECARGO_PORCION_EXTRA;
            }

            // Regla 2: Total de línea = precio unitario * cantidad. Subtotal = suma de las líneas
            decimal totalLinea = precioUnitario * cantidad;
            subtotalPedido += totalLinea;

            string detalleEtiqueta = ObtenerEtiquetaProducto(txtProducto.Text.Trim());
            string lineaFormateada = FormatearFila(
                cantidad.ToString(),
                detalleEtiqueta,
                precioUnitario.ToString("N2", CultureInfo.InvariantCulture),
                totalLinea.ToString("N2", CultureInfo.InvariantCulture)
            );

            lstPedido.Items.Add(lineaFormateada);
            lblSubtotal.Text = FormatearMoneda(subtotalPedido);

            // Reiniciar controles del producto
            ReiniciarControlesProducto();
        }

        // Evento Calcular total
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (lstPedido.Items.Count == 0 || subtotalPedido <= 0m)
            {
                MessageBox.Show("No hay productos en el pedido. Agregue al menos un producto antes de calcular.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Regla 3: Descuento 10% del subtotal si el cliente es frecuente
            decimal descuento = chkFrecuente.Checked ? subtotalPedido * PORCENTAJE_DESCUENTO : 0m;

            // Regla 4: Empaque RD$20 una sola vez por pedido si el servicio es "Para llevar"
            decimal empaque = rbtLlevar.Checked ? COSTO_EMPAQUE : 0m;

            // Regla 5: Base imponible = subtotal - descuento + empaque
            decimal baseImponible = subtotalPedido - descuento + empaque;

            // Regla 6: ITBIS = 18% de la base imponible. Total = base imponible + ITBIS
            decimal itbis = baseImponible * TASA_ITBIS;
            decimal totalPagar = baseImponible + itbis;

            lblSubtotal.Text = FormatearMoneda(subtotalPedido);
            lblDescuento.Text = FormatearMoneda(descuento);
            lblEmpaque.Text = FormatearMoneda(empaque);
            lblItbis.Text = FormatearMoneda(itbis);
            lblTotal.Text = FormatearMoneda(totalPagar);
        }

        // Evento Nuevo pedido: limpiar todo, subtotal en cero y foco en txtCliente
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            InicializarFormulario();
            txtCliente.Clear();
            chkFrecuente.Checked = false;
            dtpFecha.Value = DateTime.Today;
            txtCliente.Focus();
        }

        // Evento Salir: confirmar con MessageBox (Sí/No) antes de cerrar
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro que desea salir de la aplicación?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // --- Métodos auxiliares ---

        private void InicializarFormulario()
        {
            subtotalPedido = 0m;
            lstPedido.Items.Clear();

            lblEncabezado.Text = FormatearFila("Cant", "Producto", "Precio", "Total");

            ReiniciarControlesProducto();
            rbtLocal.Checked = true;

            lblSubtotal.Text = FormatearMoneda(0m);
            lblDescuento.Text = FormatearMoneda(0m);
            lblEmpaque.Text = FormatearMoneda(0m);
            lblItbis.Text = FormatearMoneda(0m);
            lblTotal.Text = FormatearMoneda(0m);
        }

        private void ReiniciarControlesProducto()
        {
            txtProducto.Clear();
            txtPrecio.Clear();
            nudCantidad.Value = 1;
            rbtNormal.Checked = true;
            chkPorcionExtra.Checked = false;
            txtProducto.Focus();
        }

        private string ObtenerEtiquetaProducto(string nombreProducto)
        {
            string tamano = rbtGrande.Checked ? "Grande" : "Normal";
            if (chkPorcionExtra.Checked)
            {
                return $"{nombreProducto} ({tamano}, Extra)";
            }
            return $"{nombreProducto} ({tamano})";
        }

        private string FormatearFila(string cant, string producto, string precio, string total)
        {
            if (producto.Length > ANCHO_PROD)
            {
                producto = producto.Substring(0, ANCHO_PROD);
            }

            return cant.PadRight(ANCHO_CANT) +
                   producto.PadRight(ANCHO_PROD) +
                   precio.PadLeft(ANCHO_PRECIO) +
                   total.PadLeft(ANCHO_TOTAL);
        }

        private string FormatearMoneda(decimal monto)
        {
            return $"RD$ {monto.ToString("0.00", CultureInfo.InvariantCulture)}";
        }
    }
}
