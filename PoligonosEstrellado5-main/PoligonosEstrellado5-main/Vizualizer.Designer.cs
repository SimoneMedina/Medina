namespace PoligonoEstrellado5
{
    partial class Vizualizer
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
            this.grpProcesos = new System.Windows.Forms.GroupBox();
            this.BtnColorear = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnGraficar = new System.Windows.Forms.Button();
            this.BtnAntihorario = new System.Windows.Forms.Button();
            this.grpCanvas = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.trackBarZoom = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.grpRotacion = new System.Windows.Forms.GroupBox();
            this.BtnHorario = new System.Windows.Forms.Button();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lblLado = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.grpProcesos.SuspendLayout();
            this.grpCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.grpRotacion.SuspendLayout();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpProcesos
            // 
            this.grpProcesos.Controls.Add(this.BtnColorear);
            this.grpProcesos.Controls.Add(this.BtnSalir);
            this.grpProcesos.Controls.Add(this.BtnLimpiar);
            this.grpProcesos.Controls.Add(this.BtnGraficar);
            this.grpProcesos.Location = new System.Drawing.Point(12, 159);
            this.grpProcesos.Name = "grpProcesos";
            this.grpProcesos.Size = new System.Drawing.Size(147, 217);
            this.grpProcesos.TabIndex = 0;
            this.grpProcesos.TabStop = false;
            this.grpProcesos.Text = "Procesos";
            // 
            // BtnColorear
            // 
            this.BtnColorear.Location = new System.Drawing.Point(35, 129);
            this.BtnColorear.Name = "BtnColorear";
            this.BtnColorear.Size = new System.Drawing.Size(75, 29);
            this.BtnColorear.TabIndex = 2;
            this.BtnColorear.Text = "Colorear";
            this.BtnColorear.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(35, 178);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 28);
            this.BtnSalir.TabIndex = 0;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(35, 84);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 27);
            this.BtnLimpiar.TabIndex = 1;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnGraficar
            // 
            this.BtnGraficar.Location = new System.Drawing.Point(32, 38);
            this.BtnGraficar.Name = "BtnGraficar";
            this.BtnGraficar.Size = new System.Drawing.Size(78, 31);
            this.BtnGraficar.TabIndex = 0;
            this.BtnGraficar.Text = "Graficar";
            this.BtnGraficar.UseVisualStyleBackColor = true;
            this.BtnGraficar.Click += new System.EventHandler(this.BtnGraficar_Click);
            // 
            // BtnAntihorario
            // 
            this.BtnAntihorario.Location = new System.Drawing.Point(51, 21);
            this.BtnAntihorario.Name = "BtnAntihorario";
            this.BtnAntihorario.Size = new System.Drawing.Size(61, 36);
            this.BtnAntihorario.TabIndex = 2;
            this.BtnAntihorario.Text = "<";
            this.BtnAntihorario.UseVisualStyleBackColor = true;
            // 
            // grpCanvas
            // 
            this.grpCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCanvas.Controls.Add(this.picCanvas);
            this.grpCanvas.Location = new System.Drawing.Point(183, 14);
            this.grpCanvas.Name = "grpCanvas";
            this.grpCanvas.Size = new System.Drawing.Size(838, 609);
            this.grpCanvas.TabIndex = 1;
            this.grpCanvas.TabStop = false;
            this.grpCanvas.Text = "Canvas";
            // 
            // picCanvas
            // 
            this.picCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picCanvas.Location = new System.Drawing.Point(15, 23);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(808, 568);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // trackBarZoom
            // 
            this.trackBarZoom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackBarZoom.Location = new System.Drawing.Point(198, 655);
            this.trackBarZoom.Maximum = 200;
            this.trackBarZoom.Minimum = -200;
            this.trackBarZoom.Name = "trackBarZoom";
            this.trackBarZoom.Size = new System.Drawing.Size(553, 64);
            this.trackBarZoom.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.labelHeight);
            this.groupBox3.Controls.Add(this.labelWidth);
            this.groupBox3.Location = new System.Drawing.Point(16, 396);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(143, 227);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dimensiones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Coor Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Coor X:";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(9, 81);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(33, 16);
            this.labelHeight.TabIndex = 1;
            this.labelHeight.Text = "Alto:";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(6, 32);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(48, 16);
            this.labelWidth.TabIndex = 0;
            this.labelWidth.Text = "Ancho:";
            // 
            // grpRotacion
            // 
            this.grpRotacion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.grpRotacion.Controls.Add(this.BtnHorario);
            this.grpRotacion.Controls.Add(this.BtnAntihorario);
            this.grpRotacion.Location = new System.Drawing.Point(769, 640);
            this.grpRotacion.Name = "grpRotacion";
            this.grpRotacion.Size = new System.Drawing.Size(237, 79);
            this.grpRotacion.TabIndex = 4;
            this.grpRotacion.TabStop = false;
            this.grpRotacion.Text = "Rotación";
            // 
            // BtnHorario
            // 
            this.BtnHorario.Location = new System.Drawing.Point(131, 21);
            this.BtnHorario.Name = "BtnHorario";
            this.BtnHorario.Size = new System.Drawing.Size(61, 36);
            this.BtnHorario.TabIndex = 3;
            this.BtnHorario.Text = ">";
            this.BtnHorario.UseVisualStyleBackColor = true;
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.lblLado);
            this.grpDatos.Controls.Add(this.txtRadio);
            this.grpDatos.Location = new System.Drawing.Point(12, 37);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(147, 112);
            this.grpDatos.TabIndex = 5;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Location = new System.Drawing.Point(18, 35);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(99, 16);
            this.lblLado.TabIndex = 1;
            this.lblLado.Text = "Ingresar Radio:";
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(23, 65);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(88, 22);
            this.txtRadio.TabIndex = 0;
            // 
            // Vizualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 738);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.grpRotacion);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.trackBarZoom);
            this.Controls.Add(this.grpCanvas);
            this.Controls.Add(this.grpProcesos);
            this.Name = "Vizualizer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vizualizer";
            this.Load += new System.EventHandler(this.Vizualizer_Load);
            this.grpProcesos.ResumeLayout(false);
            this.grpCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpRotacion.ResumeLayout(false);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpProcesos;
        private System.Windows.Forms.Button BtnAntihorario;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnGraficar;
        private System.Windows.Forms.GroupBox grpCanvas;
        private System.Windows.Forms.TrackBar trackBarZoom;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.GroupBox grpRotacion;
        private System.Windows.Forms.Button BtnHorario;
        private System.Windows.Forms.Button BtnColorear;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.TextBox txtRadio;
    }
}

