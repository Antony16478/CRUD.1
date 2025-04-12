namespace WinFormsApp2
{
    partial class Form1
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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CARNET = new TextBox();
            Buscar = new Button();
            buttonNombre = new TextBox();
            textBoxSeccion = new TextBox();
            textBoxNota1 = new TextBox();
            textBoxNota2 = new TextBox();
            textBoxNota3 = new TextBox();
            textBoxNota4 = new TextBox();
            BUTTONCARNET = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            CrearNuevoRegistro = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // CARNET
            // 
            CARNET.Location = new Point(331, 29);
            CARNET.Margin = new Padding(3, 4, 3, 4);
            CARNET.Name = "CARNET";
            CARNET.Size = new Size(182, 27);
            CARNET.TabIndex = 0;
            CARNET.TextAlign = HorizontalAlignment.Center;
            CARNET.TextChanged += Carnet_TextChanged;
            // 
            // Buscar
            // 
            Buscar.BackColor = SystemColors.Info;
            Buscar.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Buscar.ForeColor = SystemColors.InactiveCaptionText;
            Buscar.Location = new Point(590, 3);
            Buscar.Margin = new Padding(3, 4, 3, 4);
            Buscar.Name = "Buscar";
            Buscar.Size = new Size(148, 74);
            Buscar.TabIndex = 1;
            Buscar.Text = "Buscar";
            Buscar.UseVisualStyleBackColor = false;
            Buscar.Click += Buscar_Click;
            // 
            // buttonNombre
            // 
            buttonNombre.Location = new Point(242, 184);
            buttonNombre.Margin = new Padding(3, 4, 3, 4);
            buttonNombre.Name = "buttonNombre";
            buttonNombre.Size = new Size(461, 27);
            buttonNombre.TabIndex = 2;
            buttonNombre.TextAlign = HorizontalAlignment.Center;
            buttonNombre.TextChanged += RAPERO_TextChanged;
            // 
            // textBoxSeccion
            // 
            textBoxSeccion.Location = new Point(381, 247);
            textBoxSeccion.Margin = new Padding(3, 4, 3, 4);
            textBoxSeccion.Name = "textBoxSeccion";
            textBoxSeccion.Size = new Size(102, 27);
            textBoxSeccion.TabIndex = 3;
            textBoxSeccion.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxNota1
            // 
            textBoxNota1.Location = new Point(413, 331);
            textBoxNota1.Margin = new Padding(3, 4, 3, 4);
            textBoxNota1.Name = "textBoxNota1";
            textBoxNota1.Size = new Size(55, 27);
            textBoxNota1.TabIndex = 4;
            textBoxNota1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxNota2
            // 
            textBoxNota2.Location = new Point(413, 366);
            textBoxNota2.Margin = new Padding(3, 4, 3, 4);
            textBoxNota2.Name = "textBoxNota2";
            textBoxNota2.Size = new Size(55, 27);
            textBoxNota2.TabIndex = 5;
            textBoxNota2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxNota3
            // 
            textBoxNota3.Location = new Point(413, 401);
            textBoxNota3.Margin = new Padding(3, 4, 3, 4);
            textBoxNota3.Name = "textBoxNota3";
            textBoxNota3.Size = new Size(55, 27);
            textBoxNota3.TabIndex = 6;
            textBoxNota3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxNota4
            // 
            textBoxNota4.Location = new Point(413, 446);
            textBoxNota4.Margin = new Padding(3, 4, 3, 4);
            textBoxNota4.Name = "textBoxNota4";
            textBoxNota4.Size = new Size(55, 27);
            textBoxNota4.TabIndex = 7;
            textBoxNota4.TextAlign = HorizontalAlignment.Center;
            // 
            // BUTTONCARNET
            // 
            BUTTONCARNET.AutoSize = true;
            BUTTONCARNET.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BUTTONCARNET.Location = new Point(274, 33);
            BUTTONCARNET.Name = "BUTTONCARNET";
            BUTTONCARNET.Size = new Size(58, 20);
            BUTTONCARNET.TabIndex = 8;
            BUTTONCARNET.Text = "Carnet:";
            BUTTONCARNET.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(147, 187);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 9;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(281, 250);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 10;
            label3.Text = "Seccion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(333, 334);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 11;
            label4.Text = "Nota 1:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(333, 373);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 12;
            label5.Text = "Nota 2:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(331, 404);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 13;
            label6.Text = "Nota 3:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(333, 446);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 14;
            label7.Text = "Nota 4:";
            // 
            // CrearNuevoRegistro
            // 
            CrearNuevoRegistro.BackColor = SystemColors.Info;
            CrearNuevoRegistro.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CrearNuevoRegistro.Location = new Point(274, 506);
            CrearNuevoRegistro.Margin = new Padding(3, 4, 3, 4);
            CrearNuevoRegistro.Name = "CrearNuevoRegistro";
            CrearNuevoRegistro.Size = new Size(101, 57);
            CrearNuevoRegistro.TabIndex = 15;
            CrearNuevoRegistro.Text = "Crear";
            CrearNuevoRegistro.UseVisualStyleBackColor = false;
            CrearNuevoRegistro.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Info;
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(426, 506);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(113, 57);
            button3.TabIndex = 17;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(button3);
            Controls.Add(CrearNuevoRegistro);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BUTTONCARNET);
            Controls.Add(textBoxNota4);
            Controls.Add(textBoxNota3);
            Controls.Add(textBoxNota2);
            Controls.Add(textBoxNota1);
            Controls.Add(textBoxSeccion);
            Controls.Add(buttonNombre);
            Controls.Add(Buscar);
            Controls.Add(CARNET);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "UMG";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Carnet;
        private Button Buscar;
        private TextBox textBoxNombre;
        private TextBox textBoxSeccion;
        private TextBox textBoxNota1;
        private TextBox textBoxNota2;
        private TextBox textBoxNota3;
        private TextBox textBoxNota4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button CrearNuevoRegistro;
        private Button button3;
        private TextBox CARNET;
        private Label BUTTONCARNET;
        private TextBox RAPERO;
        private TextBox buttonNombre;
    }
}
