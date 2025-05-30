
namespace utog_labar3
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
            this.btn_lav = new System.Windows.Forms.Button();
            this.btn_pok = new System.Windows.Forms.Button();
            this.btn_sod = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_lav
            // 
            this.btn_lav.Location = new System.Drawing.Point(12, 12);
            this.btn_lav.Name = "btn_lav";
            this.btn_lav.Size = new System.Drawing.Size(150, 50);
            this.btn_lav.TabIndex = 0;
            this.btn_lav.Text = "Цены на жильё";
            this.btn_lav.UseVisualStyleBackColor = true;
            this.btn_lav.Click += new System.EventHandler(this.btn_lav_Click);
            // 
            // btn_pok
            // 
            this.btn_pok.Location = new System.Drawing.Point(168, 12);
            this.btn_pok.Name = "btn_pok";
            this.btn_pok.Size = new System.Drawing.Size(150, 50);
            this.btn_pok.TabIndex = 1;
            this.btn_pok.Text = "Инфекционные заболевания";
            this.btn_pok.UseVisualStyleBackColor = true;
            this.btn_pok.Click += new System.EventHandler(this.btn_pok_Click);
            // 
            // btn_sod
            // 
            this.btn_sod.Location = new System.Drawing.Point(324, 12);
            this.btn_sod.Name = "btn_sod";
            this.btn_sod.Size = new System.Drawing.Size(150, 50);
            this.btn_sod.TabIndex = 2;
            this.btn_sod.Text = "Пробежки";
            this.btn_sod.UseVisualStyleBackColor = true;
            this.btn_sod.Click += new System.EventHandler(this.btn_sod_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(12, 68);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(462, 50);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "ВЫХОД";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 132);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_sod);
            this.Controls.Add(this.btn_pok);
            this.Controls.Add(this.btn_lav);
            this.Name = "Form1";
            this.Text = "Меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_lav;
        private System.Windows.Forms.Button btn_pok;
        private System.Windows.Forms.Button btn_sod;
        private System.Windows.Forms.Button btn_exit;
    }
}

