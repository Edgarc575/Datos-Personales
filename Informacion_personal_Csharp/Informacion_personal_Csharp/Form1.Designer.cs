namespace Informacion_personal_Csharp
{
    partial class Form1
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
            this.lbldatospersonales = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblidentidad = new System.Windows.Forms.Label();
            this.rbviudo = new System.Windows.Forms.RadioButton();
            this.rbdivorciado = new System.Windows.Forms.RadioButton();
            this.rbsoltero = new System.Windows.Forms.RadioButton();
            this.rbcasado = new System.Windows.Forms.RadioButton();
            this.lblestadoc = new System.Windows.Forms.Label();
            this.cmbdepart = new System.Windows.Forms.ComboBox();
            this.dtpfechaNa = new System.Windows.Forms.DateTimePicker();
            this.lbldepartamento = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblfechan = new System.Windows.Forms.Label();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.lblapellidos = new System.Windows.Forms.Label();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.lblnombres = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ltmostrardatos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnllenar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbldatospersonales
            // 
            this.lbldatospersonales.AutoSize = true;
            this.lbldatospersonales.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatospersonales.Location = new System.Drawing.Point(221, 14);
            this.lbldatospersonales.Name = "lbldatospersonales";
            this.lbldatospersonales.Size = new System.Drawing.Size(326, 42);
            this.lbldatospersonales.TabIndex = 0;
            this.lbldatospersonales.Text = "Datos personales";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.lbldatospersonales);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 69);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.txtid);
            this.panel2.Controls.Add(this.lblidentidad);
            this.panel2.Controls.Add(this.rbviudo);
            this.panel2.Controls.Add(this.rbdivorciado);
            this.panel2.Controls.Add(this.rbsoltero);
            this.panel2.Controls.Add(this.rbcasado);
            this.panel2.Controls.Add(this.lblestadoc);
            this.panel2.Controls.Add(this.cmbdepart);
            this.panel2.Controls.Add(this.dtpfechaNa);
            this.panel2.Controls.Add(this.lbldepartamento);
            this.panel2.Controls.Add(this.txttelefono);
            this.panel2.Controls.Add(this.lbltelefono);
            this.panel2.Controls.Add(this.txtemail);
            this.panel2.Controls.Add(this.lblemail);
            this.panel2.Controls.Add(this.lblfechan);
            this.panel2.Controls.Add(this.txtapellidos);
            this.panel2.Controls.Add(this.lblapellidos);
            this.panel2.Controls.Add(this.txtnombres);
            this.panel2.Controls.Add(this.lblnombres);
            this.panel2.Location = new System.Drawing.Point(12, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 364);
            this.panel2.TabIndex = 2;
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(150, 13);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(217, 25);
            this.txtid.TabIndex = 22;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtid_KeyPress);
            // 
            // lblidentidad
            // 
            this.lblidentidad.AutoSize = true;
            this.lblidentidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidentidad.Location = new System.Drawing.Point(18, 18);
            this.lblidentidad.Name = "lblidentidad";
            this.lblidentidad.Size = new System.Drawing.Size(90, 20);
            this.lblidentidad.TabIndex = 21;
            this.lblidentidad.Text = "Identidad:";
            // 
            // rbviudo
            // 
            this.rbviudo.AutoSize = true;
            this.rbviudo.Location = new System.Drawing.Point(295, 323);
            this.rbviudo.Name = "rbviudo";
            this.rbviudo.Size = new System.Drawing.Size(63, 17);
            this.rbviudo.TabIndex = 20;
            this.rbviudo.TabStop = true;
            this.rbviudo.Text = "Viudo/a";
            this.rbviudo.UseVisualStyleBackColor = true;
            // 
            // rbdivorciado
            // 
            this.rbdivorciado.AutoSize = true;
            this.rbdivorciado.Location = new System.Drawing.Point(191, 323);
            this.rbdivorciado.Name = "rbdivorciado";
            this.rbdivorciado.Size = new System.Drawing.Size(87, 17);
            this.rbdivorciado.TabIndex = 19;
            this.rbdivorciado.TabStop = true;
            this.rbdivorciado.Text = "Divorciado/a";
            this.rbdivorciado.UseVisualStyleBackColor = true;
            // 
            // rbsoltero
            // 
            this.rbsoltero.AutoSize = true;
            this.rbsoltero.Location = new System.Drawing.Point(100, 323);
            this.rbsoltero.Name = "rbsoltero";
            this.rbsoltero.Size = new System.Drawing.Size(69, 17);
            this.rbsoltero.TabIndex = 18;
            this.rbsoltero.TabStop = true;
            this.rbsoltero.Text = "Soltero/a";
            this.rbsoltero.UseVisualStyleBackColor = true;
            // 
            // rbcasado
            // 
            this.rbcasado.AutoSize = true;
            this.rbcasado.Location = new System.Drawing.Point(17, 323);
            this.rbcasado.Name = "rbcasado";
            this.rbcasado.Size = new System.Drawing.Size(72, 17);
            this.rbcasado.TabIndex = 17;
            this.rbcasado.TabStop = true;
            this.rbcasado.Text = "Casado/a";
            this.rbcasado.UseVisualStyleBackColor = true;
            // 
            // lblestadoc
            // 
            this.lblestadoc.AutoSize = true;
            this.lblestadoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestadoc.Location = new System.Drawing.Point(13, 291);
            this.lblestadoc.Name = "lblestadoc";
            this.lblestadoc.Size = new System.Drawing.Size(105, 20);
            this.lblestadoc.TabIndex = 16;
            this.lblestadoc.Text = "Estado civil:";
            // 
            // cmbdepart
            // 
            this.cmbdepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbdepart.FormattingEnabled = true;
            this.cmbdepart.Items.AddRange(new object[] {
            "Cortes",
            "Yoro",
            "Atlantida",
            "Comayagua",
            "Francisco Morazan",
            "Choluteca",
            "Valle",
            "La Paz",
            "Intibuca",
            "Lempira",
            "Ocotepeque",
            "Copan",
            "Santa Barbara",
            "Colon",
            "Olancho",
            "El Paraiso",
            "Gracias a Dios",
            "Islas de la Bahia"});
            this.cmbdepart.Location = new System.Drawing.Point(150, 249);
            this.cmbdepart.Name = "cmbdepart";
            this.cmbdepart.Size = new System.Drawing.Size(217, 28);
            this.cmbdepart.TabIndex = 15;
            // 
            // dtpfechaNa
            // 
            this.dtpfechaNa.Location = new System.Drawing.Point(175, 139);
            this.dtpfechaNa.Name = "dtpfechaNa";
            this.dtpfechaNa.Size = new System.Drawing.Size(192, 20);
            this.dtpfechaNa.TabIndex = 14;
            // 
            // lbldepartamento
            // 
            this.lbldepartamento.AutoSize = true;
            this.lbldepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldepartamento.Location = new System.Drawing.Point(13, 258);
            this.lbldepartamento.Name = "lbldepartamento";
            this.lbldepartamento.Size = new System.Drawing.Size(129, 20);
            this.lbldepartamento.TabIndex = 10;
            this.lbldepartamento.Text = "Departamento:";
            // 
            // txttelefono
            // 
            this.txttelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefono.Location = new System.Drawing.Point(150, 218);
            this.txttelefono.Multiline = true;
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(217, 25);
            this.txttelefono.TabIndex = 9;
            this.txttelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelefono_KeyPress);
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefono.Location = new System.Drawing.Point(18, 218);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(84, 20);
            this.lbltelefono.TabIndex = 8;
            this.lbltelefono.Text = "Telefono:";
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(150, 175);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(217, 25);
            this.txtemail.TabIndex = 7;
            this.txtemail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtemail_KeyPress);
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(18, 175);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(58, 20);
            this.lblemail.TabIndex = 6;
            this.lblemail.Text = "Email:";
            // 
            // lblfechan
            // 
            this.lblfechan.AutoSize = true;
            this.lblfechan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechan.Location = new System.Drawing.Point(13, 139);
            this.lblfechan.Name = "lblfechan";
            this.lblfechan.Size = new System.Drawing.Size(156, 20);
            this.lblfechan.TabIndex = 4;
            this.lblfechan.Text = "Fecha nacimiento:";
            // 
            // txtapellidos
            // 
            this.txtapellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellidos.Location = new System.Drawing.Point(150, 98);
            this.txtapellidos.Multiline = true;
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(217, 25);
            this.txtapellidos.TabIndex = 3;
            this.txtapellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellidos_KeyPress);
            // 
            // lblapellidos
            // 
            this.lblapellidos.AutoSize = true;
            this.lblapellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapellidos.Location = new System.Drawing.Point(18, 98);
            this.lblapellidos.Name = "lblapellidos";
            this.lblapellidos.Size = new System.Drawing.Size(87, 20);
            this.lblapellidos.TabIndex = 2;
            this.lblapellidos.Text = "Apellidos:";
            // 
            // txtnombres
            // 
            this.txtnombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombres.Location = new System.Drawing.Point(150, 58);
            this.txtnombres.Multiline = true;
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.Size = new System.Drawing.Size(217, 25);
            this.txtnombres.TabIndex = 1;
            this.txtnombres.TextChanged += new System.EventHandler(this.txtnombres_TextChanged);
            this.txtnombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombres_KeyPress);
            // 
            // lblnombres
            // 
            this.lblnombres.AutoSize = true;
            this.lblnombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombres.Location = new System.Drawing.Point(13, 61);
            this.lblnombres.Name = "lblnombres";
            this.lblnombres.Size = new System.Drawing.Size(85, 20);
            this.lblnombres.TabIndex = 0;
            this.lblnombres.Text = "Nombres:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.ltmostrardatos);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnborrar);
            this.panel3.Controls.Add(this.btnllenar);
            this.panel3.Location = new System.Drawing.Point(397, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(391, 364);
            this.panel3.TabIndex = 3;
            // 
            // ltmostrardatos
            // 
            this.ltmostrardatos.Enabled = false;
            this.ltmostrardatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltmostrardatos.Location = new System.Drawing.Point(115, 47);
            this.ltmostrardatos.Multiline = true;
            this.ltmostrardatos.Name = "ltmostrardatos";
            this.ltmostrardatos.Size = new System.Drawing.Size(262, 302);
            this.ltmostrardatos.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Datos del usuario:";
            // 
            // btnborrar
            // 
            this.btnborrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrar.Location = new System.Drawing.Point(12, 241);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(78, 108);
            this.btnborrar.TabIndex = 13;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnllenar
            // 
            this.btnllenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnllenar.Location = new System.Drawing.Point(12, 47);
            this.btnllenar.Name = "btnllenar";
            this.btnllenar.Size = new System.Drawing.Size(78, 109);
            this.btnllenar.TabIndex = 12;
            this.btnllenar.Text = "Llenar";
            this.btnllenar.UseVisualStyleBackColor = true;
            this.btnllenar.Click += new System.EventHandler(this.btnllenar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbldatospersonales;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnllenar;
        private System.Windows.Forms.Label lbldepartamento;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblfechan;
        private System.Windows.Forms.TextBox txtapellidos;
        private System.Windows.Forms.Label lblapellidos;
        private System.Windows.Forms.TextBox txtnombres;
        private System.Windows.Forms.Label lblnombres;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpfechaNa;
        private System.Windows.Forms.RadioButton rbviudo;
        private System.Windows.Forms.RadioButton rbdivorciado;
        private System.Windows.Forms.RadioButton rbsoltero;
        private System.Windows.Forms.RadioButton rbcasado;
        private System.Windows.Forms.Label lblestadoc;
        private System.Windows.Forms.ComboBox cmbdepart;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblidentidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ltmostrardatos;
    }
}

