namespace L_oven_Meat
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btpedidoadomicilio = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlReservacion = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbhora = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtCorreo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtNumTel = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btreservacion = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gpfecha = new System.Windows.Forms.GroupBox();
            this.lbfecha = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kryptonComboBox2 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtpedidonum = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpedidonom = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ttransaccion = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlReservacion)).BeginInit();
            this.pnlReservacion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbhora)).BeginInit();
            this.gpfecha.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.groupBox2);
            this.kryptonPanel1.Controls.Add(this.listBox2);
            this.kryptonPanel1.Controls.Add(this.btpedidoadomicilio);
            this.kryptonPanel1.Controls.Add(this.label10);
            this.kryptonPanel1.Location = new System.Drawing.Point(620, 51);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(570, 477);
            this.kryptonPanel1.TabIndex = 16;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(96, 344);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(329, 121);
            this.listBox2.TabIndex = 7;
            // 
            // btpedidoadomicilio
            // 
            this.btpedidoadomicilio.Location = new System.Drawing.Point(174, 274);
            this.btpedidoadomicilio.Name = "btpedidoadomicilio";
            this.btpedidoadomicilio.Size = new System.Drawing.Size(153, 23);
            this.btpedidoadomicilio.TabIndex = 5;
            this.btpedidoadomicilio.Text = "Realizar pedido a domicilio";
            this.btpedidoadomicilio.UseVisualStyleBackColor = true;
            this.btpedidoadomicilio.Click += new System.EventHandler(this.btpedidoadomicilio_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(147, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(220, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Plano de las mesas que se van a seleccionar";
            // 
            // pnlReservacion
            // 
            this.pnlReservacion.Controls.Add(this.groupBox1);
            this.pnlReservacion.Controls.Add(this.listBox1);
            this.pnlReservacion.Controls.Add(this.btreservacion);
            this.pnlReservacion.Controls.Add(this.label5);
            this.pnlReservacion.Location = new System.Drawing.Point(12, 51);
            this.pnlReservacion.Name = "pnlReservacion";
            this.pnlReservacion.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonLowProfile;
            this.pnlReservacion.Size = new System.Drawing.Size(578, 477);
            this.pnlReservacion.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbhora);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.txtNumTel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombreCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(13, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 184);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "datos cliente";
            // 
            // cbhora
            // 
            this.cbhora.DropDownWidth = 141;
            this.cbhora.Items.AddRange(new object[] {
            "4:00 p.m",
            "4:30 p.m",
            "5:00 p.m",
            "5:30 p.m",
            "6:00 p.m",
            "6:40 p.m",
            "7:00 p.m",
            "7:30 p.m",
            "8:30 p.m",
            "9:00 p.m",
            "9:30 p.m",
            "10:00 p.m",
            "10:30 p.m"});
            this.cbhora.Location = new System.Drawing.Point(236, 131);
            this.cbhora.Name = "cbhora";
            this.cbhora.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.cbhora.Size = new System.Drawing.Size(183, 27);
            this.cbhora.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbhora.StateCommon.ComboBox.Border.Rounding = 10;
            this.cbhora.TabIndex = 10;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(236, 96);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(183, 29);
            this.txtCorreo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCorreo.StateCommon.Border.Rounding = 10;
            this.txtCorreo.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCorreo.StateNormal.Border.Rounding = 15;
            this.txtCorreo.StateNormal.Border.Width = 1;
            this.txtCorreo.TabIndex = 11;
            // 
            // txtNumTel
            // 
            this.txtNumTel.Location = new System.Drawing.Point(236, 61);
            this.txtNumTel.Name = "txtNumTel";
            this.txtNumTel.Size = new System.Drawing.Size(183, 29);
            this.txtNumTel.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNumTel.StateCommon.Border.Rounding = 10;
            this.txtNumTel.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNumTel.StateNormal.Border.Rounding = 15;
            this.txtNumTel.StateNormal.Border.Width = 1;
            this.txtNumTel.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Selecciona Hora:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(236, 26);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(183, 29);
            this.txtNombreCliente.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNombreCliente.StateCommon.Border.Rounding = 10;
            this.txtNombreCliente.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNombreCliente.StateNormal.Border.Rounding = 15;
            this.txtNombreCliente.StateNormal.Border.Width = 1;
            this.txtNombreCliente.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Correo Electrónico:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numero Telefónico:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(17, 338);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(329, 121);
            this.listBox1.TabIndex = 7;
            // 
            // btreservacion
            // 
            this.btreservacion.Location = new System.Drawing.Point(101, 264);
            this.btreservacion.Name = "btreservacion";
            this.btreservacion.Size = new System.Drawing.Size(153, 23);
            this.btreservacion.TabIndex = 5;
            this.btreservacion.Text = "Realizar reservacion";
            this.btreservacion.UseVisualStyleBackColor = true;
            this.btreservacion.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Plano de las mesas que se van a seleccionar";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "realizar reservacion";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(508, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "realizar pedido a domicilio";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gpfecha
            // 
            this.gpfecha.Controls.Add(this.lbfecha);
            this.gpfecha.Location = new System.Drawing.Point(1092, 691);
            this.gpfecha.Name = "gpfecha";
            this.gpfecha.Size = new System.Drawing.Size(69, 42);
            this.gpfecha.TabIndex = 10;
            this.gpfecha.TabStop = false;
            this.gpfecha.Text = "Fecha";
            // 
            // lbfecha
            // 
            this.lbfecha.AutoSize = true;
            this.lbfecha.Location = new System.Drawing.Point(14, 20);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(42, 13);
            this.lbfecha.TabIndex = 1;
            this.lbfecha.Text = "lbfecha";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kryptonComboBox2);
            this.groupBox2.Controls.Add(this.kryptonTextBox1);
            this.groupBox2.Controls.Add(this.txtpedidonum);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtpedidonom);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(14, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 184);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "datos cliente";
            // 
            // kryptonComboBox2
            // 
            this.kryptonComboBox2.DropDownWidth = 141;
            this.kryptonComboBox2.Items.AddRange(new object[] {
            "4:00 p.m",
            "4:30 p.m",
            "5:00 p.m",
            "5:30 p.m",
            "6:00 p.m",
            "6:40 p.m",
            "7:00 p.m",
            "7:30 p.m",
            "8:30 p.m",
            "9:00 p.m",
            "9:30 p.m",
            "10:00 p.m",
            "10:30 p.m"});
            this.kryptonComboBox2.Location = new System.Drawing.Point(236, 131);
            this.kryptonComboBox2.Name = "kryptonComboBox2";
            this.kryptonComboBox2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.kryptonComboBox2.Size = new System.Drawing.Size(147, 27);
            this.kryptonComboBox2.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonComboBox2.StateCommon.ComboBox.Border.Rounding = 10;
            this.kryptonComboBox2.TabIndex = 10;
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(236, 96);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(183, 29);
            this.kryptonTextBox1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox1.StateCommon.Border.Rounding = 10;
            this.kryptonTextBox1.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox1.StateNormal.Border.Rounding = 15;
            this.kryptonTextBox1.StateNormal.Border.Width = 1;
            this.kryptonTextBox1.TabIndex = 11;
            // 
            // txtpedidonum
            // 
            this.txtpedidonum.Location = new System.Drawing.Point(236, 61);
            this.txtpedidonum.Name = "txtpedidonum";
            this.txtpedidonum.Size = new System.Drawing.Size(183, 29);
            this.txtpedidonum.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtpedidonum.StateCommon.Border.Rounding = 10;
            this.txtpedidonum.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtpedidonum.StateNormal.Border.Rounding = 15;
            this.txtpedidonum.StateNormal.Border.Width = 1;
            this.txtpedidonum.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Selecciona Hora:";
            // 
            // txtpedidonom
            // 
            this.txtpedidonom.Location = new System.Drawing.Point(236, 26);
            this.txtpedidonom.Name = "txtpedidonom";
            this.txtpedidonom.Size = new System.Drawing.Size(183, 29);
            this.txtpedidonom.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtpedidonom.StateCommon.Border.Rounding = 10;
            this.txtpedidonom.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtpedidonom.StateNormal.Border.Rounding = 15;
            this.txtpedidonom.StateNormal.Border.Width = 1;
            this.txtpedidonom.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Correo Electrónico:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 22);
            this.label8.TabIndex = 4;
            this.label8.Text = "Numero Telefónico:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(68, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nombre:";
            // 
            // ttransaccion
            // 
            this.ttransaccion.Tick += new System.EventHandler(this.ttransaccion_Tick);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 765);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.pnlReservacion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gpfecha);
            this.Name = "Principal";
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlReservacion)).EndInit();
            this.pnlReservacion.ResumeLayout(false);
            this.pnlReservacion.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbhora)).EndInit();
            this.gpfecha.ResumeLayout(false);
            this.gpfecha.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btpedidoadomicilio;
        private System.Windows.Forms.Label label10;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlReservacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cbhora;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCorreo;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNumTel;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNombreCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btreservacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gpfecha;
        private System.Windows.Forms.Label lbfecha;
        private System.Windows.Forms.GroupBox groupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtpedidonum;
        private System.Windows.Forms.Label label6;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtpedidonom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer ttransaccion;
    }
}