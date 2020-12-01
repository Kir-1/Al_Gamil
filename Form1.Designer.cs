namespace Al_Gamil
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.giveEDSButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.checkEDSButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // giveEDSButton
            // 
            this.giveEDSButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.giveEDSButton.Location = new System.Drawing.Point(3, 3);
            this.giveEDSButton.Name = "giveEDSButton";
            this.giveEDSButton.Size = new System.Drawing.Size(200, 50);
            this.giveEDSButton.TabIndex = 0;
            this.giveEDSButton.Text = "Получение Открытого Ключа и Проверка ЭЦП";
            this.giveEDSButton.UseVisualStyleBackColor = true;
            this.giveEDSButton.Click += new System.EventHandler(this.takeEDSButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.giveEDSButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkEDSButton, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // checkEDSButton
            // 
            this.checkEDSButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkEDSButton.Location = new System.Drawing.Point(3, 59);
            this.checkEDSButton.Name = "checkEDSButton";
            this.checkEDSButton.Size = new System.Drawing.Size(200, 50);
            this.checkEDSButton.TabIndex = 1;
            this.checkEDSButton.Text = "Создать ЭЦП";
            this.checkEDSButton.UseVisualStyleBackColor = true;
            this.checkEDSButton.Click += new System.EventHandler(this.giveEDSButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button giveEDSButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button checkEDSButton;
    }
}

