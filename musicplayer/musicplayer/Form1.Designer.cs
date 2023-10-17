namespace musicplayer
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Do = new System.Windows.Forms.Button();
            this.Re = new System.Windows.Forms.Button();
            this.Mi = new System.Windows.Forms.Button();
            this.Fa = new System.Windows.Forms.Button();
            this.So = new System.Windows.Forms.Button();
            this.La = new System.Windows.Forms.Button();
            this.Si = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Do
            // 
            this.Do.Location = new System.Drawing.Point(50, 219);
            this.Do.Name = "Do";
            this.Do.Size = new System.Drawing.Size(75, 23);
            this.Do.TabIndex = 0;
            this.Do.Text = "Do";
            this.Do.UseVisualStyleBackColor = true;
            this.Do.Click += new System.EventHandler(this.Do_Click);
            this.Do.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Do_KeyPress);
            // 
            // Re
            // 
            this.Re.Location = new System.Drawing.Point(125, 219);
            this.Re.Name = "Re";
            this.Re.Size = new System.Drawing.Size(75, 23);
            this.Re.TabIndex = 1;
            this.Re.Text = "Re";
            this.Re.UseVisualStyleBackColor = true;
            this.Re.Click += new System.EventHandler(this.Re_Click);
            // 
            // Mi
            // 
            this.Mi.Location = new System.Drawing.Point(200, 219);
            this.Mi.Name = "Mi";
            this.Mi.Size = new System.Drawing.Size(75, 23);
            this.Mi.TabIndex = 2;
            this.Mi.Text = "Mi";
            this.Mi.UseVisualStyleBackColor = true;
            this.Mi.Click += new System.EventHandler(this.Mi_Click);
            // 
            // Fa
            // 
            this.Fa.Location = new System.Drawing.Point(275, 219);
            this.Fa.Name = "Fa";
            this.Fa.Size = new System.Drawing.Size(75, 23);
            this.Fa.TabIndex = 3;
            this.Fa.Text = "Fa";
            this.Fa.UseVisualStyleBackColor = true;
            this.Fa.Click += new System.EventHandler(this.Fa_Click);
            // 
            // So
            // 
            this.So.Location = new System.Drawing.Point(350, 219);
            this.So.Name = "So";
            this.So.Size = new System.Drawing.Size(75, 23);
            this.So.TabIndex = 4;
            this.So.Text = "So";
            this.So.UseVisualStyleBackColor = true;
            this.So.Click += new System.EventHandler(this.So_Click);
            // 
            // La
            // 
            this.La.Location = new System.Drawing.Point(425, 219);
            this.La.Name = "La";
            this.La.Size = new System.Drawing.Size(75, 23);
            this.La.TabIndex = 5;
            this.La.Text = "La";
            this.La.UseVisualStyleBackColor = true;
            this.La.Click += new System.EventHandler(this.La_Click);
            // 
            // Si
            // 
            this.Si.Location = new System.Drawing.Point(500, 219);
            this.Si.Name = "Si";
            this.Si.Size = new System.Drawing.Size(75, 23);
            this.Si.TabIndex = 6;
            this.Si.Text = "Si";
            this.Si.UseVisualStyleBackColor = true;
            this.Si.Click += new System.EventHandler(this.Si_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 294);
            this.Controls.Add(this.Si);
            this.Controls.Add(this.La);
            this.Controls.Add(this.So);
            this.Controls.Add(this.Fa);
            this.Controls.Add(this.Mi);
            this.Controls.Add(this.Re);
            this.Controls.Add(this.Do);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Do;
        private System.Windows.Forms.Button Re;
        private System.Windows.Forms.Button Mi;
        private System.Windows.Forms.Button Fa;
        private System.Windows.Forms.Button So;
        private System.Windows.Forms.Button La;
        private System.Windows.Forms.Button Si;
    }
}

