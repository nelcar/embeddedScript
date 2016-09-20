namespace WindowsFormsApplication1
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
            this.txtBox = new System.Windows.Forms.RichTextBox();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(12, 12);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(481, 374);
            this.txtBox.TabIndex = 0;
            this.txtBox.Text = "";
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(215, 395);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(75, 23);
            this.btnEjecutar.TabIndex = 1;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 430);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.txtBox);
            this.Name = "Form1";
            this.Text = "Proyecto de Lenguajes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtBox;
        private System.Windows.Forms.Button btnEjecutar;
    }
}

