namespace Paint
{
    partial class Paint
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.ClearClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel.Location = new System.Drawing.Point(306, 35);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1302, 1169);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_MouseUp);
            // 
            // ClearClick
            // 
            this.ClearClick.Location = new System.Drawing.Point(21, 35);
            this.ClearClick.Name = "ClearClick";
            this.ClearClick.Size = new System.Drawing.Size(265, 1169);
            this.ClearClick.TabIndex = 1;
            this.ClearClick.Text = "Очистить";
            this.ClearClick.UseVisualStyleBackColor = true;
            this.ClearClick.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 1275);
            this.Controls.Add(this.ClearClick);
            this.Controls.Add(this.panel);
            this.Name = "Paint";
            this.Text = "Paint";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button ClearClick;
    }
}

