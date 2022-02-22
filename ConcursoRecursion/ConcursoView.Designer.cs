namespace ConcursoRecursion
{
    partial class ConcursoView
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.RetoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ConcursoTimer = new System.Windows.Forms.Timer(this.components);
            this.TiempoTextBox = new System.Windows.Forms.TextBox();
            this.IniciarButton = new System.Windows.Forms.Button();
            this.NuevoRetoButton = new System.Windows.Forms.Button();
            this.PausarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(365, 9);
            this.label1.MinimumSize = new System.Drawing.Size(182, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RetoTextBox
            // 
            this.RetoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RetoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RetoTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.RetoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetoTextBox.Location = new System.Drawing.Point(12, 81);
            this.RetoTextBox.Multiline = true;
            this.RetoTextBox.Name = "RetoTextBox";
            this.RetoTextBox.ReadOnly = true;
            this.RetoTextBox.Size = new System.Drawing.Size(887, 98);
            this.RetoTextBox.TabIndex = 1;
            this.RetoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(320, 182);
            this.label2.MinimumSize = new System.Drawing.Size(238, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 69);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tiempo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConcursoTimer
            // 
            this.ConcursoTimer.Interval = 1000;
            this.ConcursoTimer.Tick += new System.EventHandler(this.ConcursoTimer_Tick);
            // 
            // TiempoTextBox
            // 
            this.TiempoTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TiempoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TiempoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TiempoTextBox.Location = new System.Drawing.Point(296, 254);
            this.TiempoTextBox.Multiline = true;
            this.TiempoTextBox.Name = "TiempoTextBox";
            this.TiempoTextBox.ReadOnly = true;
            this.TiempoTextBox.Size = new System.Drawing.Size(310, 72);
            this.TiempoTextBox.TabIndex = 3;
            this.TiempoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IniciarButton
            // 
            this.IniciarButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IniciarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarButton.Location = new System.Drawing.Point(358, 332);
            this.IniciarButton.Name = "IniciarButton";
            this.IniciarButton.Size = new System.Drawing.Size(81, 37);
            this.IniciarButton.TabIndex = 4;
            this.IniciarButton.Text = "Iniciar";
            this.IniciarButton.UseVisualStyleBackColor = true;
            this.IniciarButton.Click += new System.EventHandler(this.IniciarButton_Click);
            // 
            // NuevoRetoButton
            // 
            this.NuevoRetoButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NuevoRetoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoRetoButton.Location = new System.Drawing.Point(0, 404);
            this.NuevoRetoButton.Name = "NuevoRetoButton";
            this.NuevoRetoButton.Size = new System.Drawing.Size(904, 46);
            this.NuevoRetoButton.TabIndex = 5;
            this.NuevoRetoButton.Text = "Nuevo Reto";
            this.NuevoRetoButton.UseVisualStyleBackColor = true;
            this.NuevoRetoButton.Click += new System.EventHandler(this.NuevoRetoButton_Click);
            // 
            // PausarButton
            // 
            this.PausarButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PausarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PausarButton.Location = new System.Drawing.Point(466, 332);
            this.PausarButton.Name = "PausarButton";
            this.PausarButton.Size = new System.Drawing.Size(91, 37);
            this.PausarButton.TabIndex = 6;
            this.PausarButton.Text = "Pausar";
            this.PausarButton.UseVisualStyleBackColor = true;
            this.PausarButton.Click += new System.EventHandler(this.PausarButton_Click);
            // 
            // ConcursoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 450);
            this.Controls.Add(this.PausarButton);
            this.Controls.Add(this.NuevoRetoButton);
            this.Controls.Add(this.IniciarButton);
            this.Controls.Add(this.TiempoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RetoTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ConcursoView";
            this.Text = "Concurso Recursión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RetoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer ConcursoTimer;
        private System.Windows.Forms.TextBox TiempoTextBox;
        private System.Windows.Forms.Button IniciarButton;
        private System.Windows.Forms.Button NuevoRetoButton;
        private System.Windows.Forms.Button PausarButton;
    }
}

