
namespace practica8
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.glbdatos = new System.Windows.Forms.GroupBox();
            this.txtcodigoalumno = new System.Windows.Forms.TextBox();
            this.lblcodigoalumnos = new System.Windows.Forms.Label();
            this.lblcodigoalumno = new System.Windows.Forms.Label();
            this.txtalumnos = new System.Windows.Forms.TextBox();
            this.lbldireccionalumno = new System.Windows.Forms.Label();
            this.txtdireccionalumno = new System.Windows.Forms.TextBox();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.txttelefonoalumno = new System.Windows.Forms.TextBox();
            this.lbldui = new System.Windows.Forms.Label();
            this.txtduialumnos = new System.Windows.Forms.TextBox();
            this.glbnavegacion = new System.Windows.Forms.GroupBox();
            this.glbedicion = new System.Windows.Forms.GroupBox();
            this.btnavegacion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.glbdatos.SuspendLayout();
            this.glbnavegacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // glbdatos
            // 
            this.glbdatos.Controls.Add(this.lbldui);
            this.glbdatos.Controls.Add(this.txtduialumnos);
            this.glbdatos.Controls.Add(this.lbltelefono);
            this.glbdatos.Controls.Add(this.txttelefonoalumno);
            this.glbdatos.Controls.Add(this.lbldireccionalumno);
            this.glbdatos.Controls.Add(this.txtdireccionalumno);
            this.glbdatos.Controls.Add(this.lblcodigoalumno);
            this.glbdatos.Controls.Add(this.txtalumnos);
            this.glbdatos.Controls.Add(this.lblcodigoalumnos);
            this.glbdatos.Controls.Add(this.txtcodigoalumno);
            this.glbdatos.Location = new System.Drawing.Point(13, 13);
            this.glbdatos.Name = "glbdatos";
            this.glbdatos.Size = new System.Drawing.Size(528, 312);
            this.glbdatos.TabIndex = 0;
            this.glbdatos.TabStop = false;
            this.glbdatos.Text = "Datos Alumnos";
            this.glbdatos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtcodigoalumno
            // 
            this.txtcodigoalumno.Location = new System.Drawing.Point(97, 44);
            this.txtcodigoalumno.Name = "txtcodigoalumno";
            this.txtcodigoalumno.Size = new System.Drawing.Size(100, 20);
            this.txtcodigoalumno.TabIndex = 0;
            // 
            // lblcodigoalumnos
            // 
            this.lblcodigoalumnos.AutoSize = true;
            this.lblcodigoalumnos.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigoalumnos.Location = new System.Drawing.Point(6, 41);
            this.lblcodigoalumnos.Name = "lblcodigoalumnos";
            this.lblcodigoalumnos.Size = new System.Drawing.Size(70, 23);
            this.lblcodigoalumnos.TabIndex = 1;
            this.lblcodigoalumnos.Text = "Codigo:";
            // 
            // lblcodigoalumno
            // 
            this.lblcodigoalumno.AutoSize = true;
            this.lblcodigoalumno.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigoalumno.Location = new System.Drawing.Point(6, 82);
            this.lblcodigoalumno.Name = "lblcodigoalumno";
            this.lblcodigoalumno.Size = new System.Drawing.Size(75, 23);
            this.lblcodigoalumno.TabIndex = 3;
            this.lblcodigoalumno.Text = "Nombre:";
            // 
            // txtalumnos
            // 
            this.txtalumnos.Location = new System.Drawing.Point(97, 85);
            this.txtalumnos.Name = "txtalumnos";
            this.txtalumnos.Size = new System.Drawing.Size(307, 20);
            this.txtalumnos.TabIndex = 2;
            // 
            // lbldireccionalumno
            // 
            this.lbldireccionalumno.AutoSize = true;
            this.lbldireccionalumno.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldireccionalumno.Location = new System.Drawing.Point(6, 125);
            this.lbldireccionalumno.Name = "lbldireccionalumno";
            this.lbldireccionalumno.Size = new System.Drawing.Size(87, 23);
            this.lbldireccionalumno.TabIndex = 5;
            this.lbldireccionalumno.Text = "Direccion:";
            // 
            // txtdireccionalumno
            // 
            this.txtdireccionalumno.Location = new System.Drawing.Point(97, 128);
            this.txtdireccionalumno.Name = "txtdireccionalumno";
            this.txtdireccionalumno.Size = new System.Drawing.Size(307, 20);
            this.txtdireccionalumno.TabIndex = 4;
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefono.Location = new System.Drawing.Point(6, 162);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(82, 23);
            this.lbltelefono.TabIndex = 7;
            this.lbltelefono.Text = "Telefono:";
            // 
            // txttelefonoalumno
            // 
            this.txttelefonoalumno.Location = new System.Drawing.Point(97, 162);
            this.txttelefonoalumno.Name = "txttelefonoalumno";
            this.txttelefonoalumno.Size = new System.Drawing.Size(131, 20);
            this.txttelefonoalumno.TabIndex = 6;
            // 
            // lbldui
            // 
            this.lbldui.AutoSize = true;
            this.lbldui.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldui.Location = new System.Drawing.Point(6, 201);
            this.lbldui.Name = "lbldui";
            this.lbldui.Size = new System.Drawing.Size(41, 23);
            this.lbldui.TabIndex = 9;
            this.lbldui.Text = "DUI:";
            // 
            // txtduialumnos
            // 
            this.txtduialumnos.Location = new System.Drawing.Point(97, 201);
            this.txtduialumnos.Name = "txtduialumnos";
            this.txtduialumnos.Size = new System.Drawing.Size(131, 20);
            this.txtduialumnos.TabIndex = 8;
            // 
            // glbnavegacion
            // 
            this.glbnavegacion.Controls.Add(this.button2);
            this.glbnavegacion.Controls.Add(this.button3);
            this.glbnavegacion.Controls.Add(this.button1);
            this.glbnavegacion.Controls.Add(this.btnavegacion);
            this.glbnavegacion.Location = new System.Drawing.Point(13, 340);
            this.glbnavegacion.Name = "glbnavegacion";
            this.glbnavegacion.Size = new System.Drawing.Size(212, 89);
            this.glbnavegacion.TabIndex = 1;
            this.glbnavegacion.TabStop = false;
            this.glbnavegacion.Text = "Navegacion";
            this.glbnavegacion.Enter += new System.EventHandler(this.glbnavegacion_Enter);
            // 
            // glbedicion
            // 
            this.glbedicion.Location = new System.Drawing.Point(252, 340);
            this.glbedicion.Name = "glbedicion";
            this.glbedicion.Size = new System.Drawing.Size(289, 89);
            this.glbedicion.TabIndex = 2;
            this.glbedicion.TabStop = false;
            this.glbedicion.Text = "Navegacion";
            // 
            // btnavegacion
            // 
            this.btnavegacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnavegacion.Location = new System.Drawing.Point(-5, 19);
            this.btnavegacion.Name = "btnavegacion";
            this.btnavegacion.Size = new System.Drawing.Size(47, 50);
            this.btnavegacion.TabIndex = 0;
            this.btnavegacion.Text = "|<";
            this.btnavegacion.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(36, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(165, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = ">|";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(124, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 486);
            this.Controls.Add(this.glbedicion);
            this.Controls.Add(this.glbnavegacion);
            this.Controls.Add(this.glbdatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.glbdatos.ResumeLayout(false);
            this.glbdatos.PerformLayout();
            this.glbnavegacion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox glbdatos;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.TextBox txttelefonoalumno;
        private System.Windows.Forms.Label lbldireccionalumno;
        private System.Windows.Forms.TextBox txtdireccionalumno;
        private System.Windows.Forms.Label lblcodigoalumno;
        private System.Windows.Forms.TextBox txtalumnos;
        private System.Windows.Forms.Label lblcodigoalumnos;
        private System.Windows.Forms.TextBox txtcodigoalumno;
        private System.Windows.Forms.Label lbldui;
        private System.Windows.Forms.TextBox txtduialumnos;
        private System.Windows.Forms.GroupBox glbnavegacion;
        private System.Windows.Forms.GroupBox glbedicion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnavegacion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

