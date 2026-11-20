# Examen Práctico – Programación Básica
## Caso Práctico: Pedidos de la Cafetería "El Buen Sabor"

### 1. Datos del Estudiante
* **Nombre:** [Eirin Idalgis Bastardo Familia]
* **Matrícula:** [2024-1270]
* **Asignatura:** Programación Básica (Windows Forms - C#)

---

### 2. Descripción del Programa
Aplicación de escritorio desarrollada en **C# (Windows Forms)** que permite gestionar y facturar pedidos de la cafetería *"El Buen Sabor"*. El sistema calcula el precio unitario según el tamaño y extras seleccionados, acumula múltiples líneas de pedido en un listado con columnas alineadas y determina el subtotal, descuento por cliente frecuente, cargo de empaque para llevar, ITBIS (18 %) y el total final a pagar.

---

### 3. Datos de Entrada
* **Cliente:** Nombre del cliente (`txtCliente`) y condición de cliente frecuente (`chkFrecuente`).
* **Fecha:** Fecha del pedido (`dtpFecha`).
* **Producto:** Nombre (`txtProducto`), precio base (`txtPrecio`) y cantidad de unidades de 1 a 20 (`nudCantidad`).
* **Opciones del producto:** Tamaño Normal o Grande (`rbtNormal`, `rbtGrande`) y porción extra (`chkPorcionExtra`).
* **Tipo de servicio:** Consumir en local o Para llevar (`rbtLocal`, `rbtLlevar`).

---

### 4. Proceso (Reglas de Negocio)
1. **Precio unitario:** `precio digitado + RD$25` (si es tamaño Grande) `+ RD$30` (si lleva porción extra).
2. **Total de línea y Subtotal:** `total línea = precio unitario × cantidad`; `subtotal = suma de todas las líneas`.
3. **Descuento:** `10 %` del subtotal si el cliente está marcado como frecuente.
4. **Empaque:** `RD$20` una sola vez por pedido si el servicio es *Para llevar*.
5. **Base imponible:** `subtotal - descuento + empaque`.
6. **ITBIS y Total:** `ITBIS = 18 %` de la base imponible; `Total a pagar = base imponible + ITBIS`.

---

### 5. Datos de Salida
* Detalle alineado por columnas (`Cant`, `Producto`, `Precio`, `Total`) en `lstPedido`.
* Resumen financiero en etiquetas con formato moneda (`RD$ 0.00`): **Subtotal**, **Descuento**, **Empaque**, **ITBIS (18 %)** y **Total a pagar**.

---

### 6. Capturas de Pantalla del Programa en Ejecución
*(Inserta aquí las capturas de pantalla de tu aplicación ejecutando el caso de prueba)*


