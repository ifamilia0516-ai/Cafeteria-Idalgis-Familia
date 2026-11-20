namespace Examen_Cafeteria_SuNombre
{
    partial class frmPedidos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedidos));
            lblTituloCliente = new Label();
            txtCliente = new TextBox();
            chkFrecuente = new CheckBox();
            lblTituloFecha = new Label();
            dtpFecha = new DateTimePicker();
            lblTituloProducto = new Label();
            txtProducto = new TextBox();
            lblTituloPrecio = new Label();
            txtPrecio = new TextBox();
            lblTituloCantidad = new Label();
            nudCantidad = new NumericUpDown();
            grpTamano = new GroupBox();
            rbtGrande = new RadioButton();
            rbtNormal = new RadioButton();
            grpServicio = new GroupBox();
            rbtLlevar = new RadioButton();
            rbtLocal = new RadioButton();
            chkPorcionExtra = new CheckBox();
            btnAgregar = new Button();
            lblEncabezado = new Label();
            lstPedido = new ListBox();
            lblTituloSubtotal = new Label();
            lblSubtotal = new Label();
            lblTituloDescuento = new Label();
            lblDescuento = new Label();
            lblTituloEmpaque = new Label();
            lblEmpaque = new Label();
            lblTituloItbis = new Label();
            lblItbis = new Label();
            lblTituloTotal = new Label();
            lblTotal = new Label();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            grpTamano.SuspendLayout();
            grpServicio.SuspendLayout();
            SuspendLayout();
            // 
            // lblTituloCliente
            // 
            lblTituloCliente.AutoSize = true;
            lblTituloCliente.Location = new Point(19, 13);
            lblTituloCliente.Name = "lblTituloCliente";
            lblTituloCliente.Size = new Size(53, 14);
            lblTituloCliente.TabIndex = 0;
            lblTituloCliente.Text = "Cliente";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(84, 9);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(260, 23);
            txtCliente.TabIndex = 1;
            // 
            // chkFrecuente
            // 
            chkFrecuente.AutoSize = true;
            chkFrecuente.Location = new Point(19, 42);
            chkFrecuente.Name = "chkFrecuente";
            chkFrecuente.Size = new Size(139, 18);
            chkFrecuente.TabIndex = 2;
            chkFrecuente.Text = "Cliente frecuente";
            chkFrecuente.UseVisualStyleBackColor = true;
            // 
            // lblTituloFecha
            // 
            lblTituloFecha.AutoSize = true;
            lblTituloFecha.Location = new Point(19, 71);
            lblTituloFecha.Name = "lblTituloFecha";
            lblTituloFecha.Size = new Size(45, 14);
            lblTituloFecha.TabIndex = 3;
            lblTituloFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(84, 67);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(260, 23);
            dtpFecha.TabIndex = 4;
            // 
            // lblTituloProducto
            // 
            lblTituloProducto.AutoSize = true;
            lblTituloProducto.Location = new Point(19, 104);
            lblTituloProducto.Name = "lblTituloProducto";
            lblTituloProducto.Size = new Size(64, 14);
            lblTituloProducto.TabIndex = 5;
            lblTituloProducto.Text = "Producto";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(84, 101);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(260, 23);
            txtProducto.TabIndex = 6;
            // 
            // lblTituloPrecio
            // 
            lblTituloPrecio.AutoSize = true;
            lblTituloPrecio.Location = new Point(19, 137);
            lblTituloPrecio.Name = "lblTituloPrecio";
            lblTituloPrecio.Size = new Size(47, 14);
            lblTituloPrecio.TabIndex = 7;
            lblTituloPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(84, 135);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(260, 23);
            txtPrecio.TabIndex = 8;
            // 
            // lblTituloCantidad
            // 
            lblTituloCantidad.AutoSize = true;
            lblTituloCantidad.Location = new Point(19, 170);
            lblTituloCantidad.Name = "lblTituloCantidad";
            lblTituloCantidad.Size = new Size(64, 14);
            lblTituloCantidad.TabIndex = 9;
            lblTituloCantidad.Text = "Cantidad";
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(84, 169);
            nudCantidad.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(110, 23);
            nudCantidad.TabIndex = 10;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // grpTamano
            // 
            grpTamano.Controls.Add(rbtGrande);
            grpTamano.Controls.Add(rbtNormal);
            grpTamano.Location = new Point(19, 204);
            grpTamano.Name = "grpTamano";
            grpTamano.Size = new Size(155, 86);
            grpTamano.TabIndex = 11;
            grpTamano.TabStop = false;
            grpTamano.Text = "Tamaño";
            // 
            // rbtGrande
            // 
            rbtGrande.AutoSize = true;
            rbtGrande.Location = new Point(14, 52);
            rbtGrande.Name = "rbtGrande";
            rbtGrande.Size = new Size(127, 18);
            rbtGrande.TabIndex = 1;
            rbtGrande.Text = "Grande (+RD$25)";
            rbtGrande.UseVisualStyleBackColor = true;
            // 
            // rbtNormal
            // 
            rbtNormal.AutoSize = true;
            rbtNormal.Checked = true;
            rbtNormal.Location = new Point(14, 24);
            rbtNormal.Name = "rbtNormal";
            rbtNormal.Size = new Size(72, 18);
            rbtNormal.TabIndex = 0;
            rbtNormal.TabStop = true;
            rbtNormal.Text = "Normal";
            rbtNormal.UseVisualStyleBackColor = true;
            // 
            // grpServicio
            // 
            grpServicio.BackColor = Color.White;
            grpServicio.Controls.Add(rbtLlevar);
            grpServicio.Controls.Add(rbtLocal);
            grpServicio.Location = new Point(184, 204);
            grpServicio.Name = "grpServicio";
            grpServicio.Size = new Size(173, 86);
            grpServicio.TabIndex = 12;
            grpServicio.TabStop = false;
            grpServicio.Text = "Servicio";
            // 
            // rbtLlevar
            // 
            rbtLlevar.AutoSize = true;
            rbtLlevar.Location = new Point(12, 52);
            rbtLlevar.Name = "rbtLlevar";
            rbtLlevar.Size = new Size(162, 18);
            rbtLlevar.TabIndex = 1;
            rbtLlevar.Text = "Para llevar (+RD$20)";
            rbtLlevar.UseVisualStyleBackColor = true;
            // 
            // rbtLocal
            // 
            rbtLocal.AutoSize = true;
            rbtLocal.Checked = true;
            rbtLocal.Location = new Point(12, 24);
            rbtLocal.Name = "rbtLocal";
            rbtLocal.Size = new Size(138, 18);
            rbtLocal.TabIndex = 0;
            rbtLocal.TabStop = true;
            rbtLocal.Text = "Consumir en local";
            rbtLocal.UseVisualStyleBackColor = true;
            // 
            // chkPorcionExtra
            // 
            chkPorcionExtra.AutoSize = true;
            chkPorcionExtra.Location = new Point(19, 302);
            chkPorcionExtra.Name = "chkPorcionExtra";
            chkPorcionExtra.Size = new Size(171, 18);
            chkPorcionExtra.TabIndex = 13;
            chkPorcionExtra.Text = "Porción extra (+RD$30)";
            chkPorcionExtra.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Algerian", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(402, 17);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(395, 32);
            btnAgregar.TabIndex = 14;
            btnAgregar.Text = "Agregar al pedido";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblEncabezado
            // 
            lblEncabezado.AutoSize = true;
            lblEncabezado.Font = new Font("Consolas", 9.5F, FontStyle.Bold);
            lblEncabezado.Location = new Point(402, 56);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(371, 15);
            lblEncabezado.TabIndex = 15;
            lblEncabezado.Text = "Cant  Producto                    Precio       Total";
            // 
            // lstPedido
            // 
            lstPedido.Font = new Font("Consolas", 9.5F);
            lstPedido.FormattingEnabled = true;
            lstPedido.ItemHeight = 15;
            lstPedido.Location = new Point(402, 77);
            lstPedido.Name = "lstPedido";
            lstPedido.Size = new Size(371, 139);
            lstPedido.TabIndex = 16;
            // 
            // lblTituloSubtotal
            // 
            lblTituloSubtotal.AutoSize = true;
            lblTituloSubtotal.Location = new Point(480, 240);
            lblTituloSubtotal.Name = "lblTituloSubtotal";
            lblTituloSubtotal.Size = new Size(66, 14);
            lblTituloSubtotal.TabIndex = 17;
            lblTituloSubtotal.Text = "Subtotal";
            // 
            // lblSubtotal
            // 
            lblSubtotal.BackColor = Color.White;
            lblSubtotal.BorderStyle = BorderStyle.FixedSingle;
            lblSubtotal.Location = new Point(617, 237);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(130, 18);
            lblSubtotal.TabIndex = 18;
            lblSubtotal.Text = "RD$ 0.00";
            lblSubtotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTituloDescuento
            // 
            lblTituloDescuento.AutoSize = true;
            lblTituloDescuento.Location = new Point(480, 266);
            lblTituloDescuento.Name = "lblTituloDescuento";
            lblTituloDescuento.Size = new Size(70, 14);
            lblTituloDescuento.TabIndex = 19;
            lblTituloDescuento.Text = "Descuento";
            // 
            // lblDescuento
            // 
            lblDescuento.BackColor = Color.White;
            lblDescuento.BorderStyle = BorderStyle.FixedSingle;
            lblDescuento.Location = new Point(617, 263);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(130, 18);
            lblDescuento.TabIndex = 20;
            lblDescuento.Text = "RD$ 0.00";
            lblDescuento.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTituloEmpaque
            // 
            lblTituloEmpaque.AutoSize = true;
            lblTituloEmpaque.Location = new Point(480, 292);
            lblTituloEmpaque.Name = "lblTituloEmpaque";
            lblTituloEmpaque.Size = new Size(61, 14);
            lblTituloEmpaque.TabIndex = 21;
            lblTituloEmpaque.Text = "Empaque";
            // 
            // lblEmpaque
            // 
            lblEmpaque.BackColor = Color.White;
            lblEmpaque.BorderStyle = BorderStyle.FixedSingle;
            lblEmpaque.Location = new Point(617, 290);
            lblEmpaque.Name = "lblEmpaque";
            lblEmpaque.Size = new Size(130, 18);
            lblEmpaque.TabIndex = 22;
            lblEmpaque.Text = "RD$ 0.00";
            lblEmpaque.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTituloItbis
            // 
            lblTituloItbis.AutoSize = true;
            lblTituloItbis.Location = new Point(480, 318);
            lblTituloItbis.Name = "lblTituloItbis";
            lblTituloItbis.Size = new Size(75, 14);
            lblTituloItbis.TabIndex = 23;
            lblTituloItbis.Text = "ITBIS (18 %)";
            // 
            // lblItbis
            // 
            lblItbis.BackColor = Color.White;
            lblItbis.BorderStyle = BorderStyle.FixedSingle;
            lblItbis.Location = new Point(617, 316);
            lblItbis.Name = "lblItbis";
            lblItbis.Size = new Size(130, 18);
            lblItbis.TabIndex = 24;
            lblItbis.Text = "RD$ 0.00";
            lblItbis.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTituloTotal
            // 
            lblTituloTotal.AutoSize = true;
            lblTituloTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTituloTotal.Location = new Point(480, 346);
            lblTituloTotal.Name = "lblTituloTotal";
            lblTituloTotal.Size = new Size(96, 15);
            lblTituloTotal.TabIndex = 25;
            lblTituloTotal.Text = "TOTAL A PAGAR";
            // 
            // lblTotal
            // 
            lblTotal.BackColor = Color.White;
            lblTotal.BorderStyle = BorderStyle.FixedSingle;
            lblTotal.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTotal.Location = new Point(617, 342);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(130, 20);
            lblTotal.TabIndex = 26;
            lblTotal.Text = "RD$ 0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCalcular.Location = new Point(19, 338);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(120, 32);
            btnCalcular.TabIndex = 27;
            btnCalcular.Text = "Calcular total";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(149, 338);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(115, 32);
            btnLimpiar.TabIndex = 28;
            btnLimpiar.Text = "Nuevo pedido";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(274, 338);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(70, 32);
            btnSalir.TabIndex = 29;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(814, 382);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(lblTotal);
            Controls.Add(lblTituloTotal);
            Controls.Add(lblItbis);
            Controls.Add(lblTituloItbis);
            Controls.Add(lblEmpaque);
            Controls.Add(lblTituloEmpaque);
            Controls.Add(lblDescuento);
            Controls.Add(lblTituloDescuento);
            Controls.Add(lblSubtotal);
            Controls.Add(lblTituloSubtotal);
            Controls.Add(lstPedido);
            Controls.Add(lblEncabezado);
            Controls.Add(btnAgregar);
            Controls.Add(chkPorcionExtra);
            Controls.Add(grpServicio);
            Controls.Add(grpTamano);
            Controls.Add(nudCantidad);
            Controls.Add(lblTituloCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(lblTituloPrecio);
            Controls.Add(txtProducto);
            Controls.Add(lblTituloProducto);
            Controls.Add(dtpFecha);
            Controls.Add(lblTituloFecha);
            Controls.Add(chkFrecuente);
            Controls.Add(txtCliente);
            Controls.Add(lblTituloCliente);
            Font = new Font("Algerian", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmPedidos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cafetería El Buen Sabor - Pedidos";
            Load += frmPedidos_Load;
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            grpTamano.ResumeLayout(false);
            grpTamano.PerformLayout();
            grpServicio.ResumeLayout(false);
            grpServicio.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTituloCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.CheckBox chkFrecuente;
        private System.Windows.Forms.Label lblTituloFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblTituloProducto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label lblTituloPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblTituloCantidad;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.GroupBox grpTamano;
        private System.Windows.Forms.RadioButton rbtGrande;
        private System.Windows.Forms.RadioButton rbtNormal;
        private System.Windows.Forms.GroupBox grpServicio;
        private System.Windows.Forms.RadioButton rbtLlevar;
        private System.Windows.Forms.RadioButton rbtLocal;
        private System.Windows.Forms.CheckBox chkPorcionExtra;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.ListBox lstPedido;
        private System.Windows.Forms.Label lblTituloSubtotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTituloDescuento;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblTituloEmpaque;
        private System.Windows.Forms.Label lblEmpaque;
        private System.Windows.Forms.Label lblTituloItbis;
        private System.Windows.Forms.Label lblItbis;
        private System.Windows.Forms.Label lblTituloTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}
