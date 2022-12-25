namespace Планировщик_рабочего_времени
{
    partial class ГлавнаяРуководитель
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.профильToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПарольToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.телефонныйСправочникToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьPdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.неВыполненныеЗаданияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетОбАктивностяхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заданияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.написаниеЗаданийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрАктивностейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.администрированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникДолжностейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pdfviewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.профильToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.заданияToolStripMenuItem,
            this.администрированиеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(710, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // профильToolStripMenuItem
            // 
            this.профильToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменитьПарольToolStripMenuItem,
            this.телефонныйСправочникToolStripMenuItem1,
            this.открытьPdfToolStripMenuItem});
            this.профильToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.профильToolStripMenuItem.Name = "профильToolStripMenuItem";
            this.профильToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.профильToolStripMenuItem.Text = "Профиль";
            // 
            // сменитьПарольToolStripMenuItem
            // 
            this.сменитьПарольToolStripMenuItem.Name = "сменитьПарольToolStripMenuItem";
            this.сменитьПарольToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.сменитьПарольToolStripMenuItem.Text = "Сменить пароль";
            this.сменитьПарольToolStripMenuItem.Click += new System.EventHandler(this.сменитьПарольToolStripMenuItem_Click);
            // 
            // телефонныйСправочникToolStripMenuItem1
            // 
            this.телефонныйСправочникToolStripMenuItem1.Name = "телефонныйСправочникToolStripMenuItem1";
            this.телефонныйСправочникToolStripMenuItem1.Size = new System.Drawing.Size(270, 26);
            this.телефонныйСправочникToolStripMenuItem1.Text = "Телефонный справочник";
            this.телефонныйСправочникToolStripMenuItem1.Click += new System.EventHandler(this.телефонныйСправочникToolStripMenuItem1_Click);
            // 
            // открытьPdfToolStripMenuItem
            // 
            this.открытьPdfToolStripMenuItem.Name = "открытьPdfToolStripMenuItem";
            this.открытьPdfToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.открытьPdfToolStripMenuItem.Text = "Открыть pdf";
            this.открытьPdfToolStripMenuItem.Click += new System.EventHandler(this.открытьPdfToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.неВыполненныеЗаданияToolStripMenuItem,
            this.отчетОбАктивностяхToolStripMenuItem});
            this.отчетыToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // неВыполненныеЗаданияToolStripMenuItem
            // 
            this.неВыполненныеЗаданияToolStripMenuItem.Name = "неВыполненныеЗаданияToolStripMenuItem";
            this.неВыполненныеЗаданияToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.неВыполненныеЗаданияToolStripMenuItem.Text = "Не выполненные задания";
            this.неВыполненныеЗаданияToolStripMenuItem.Click += new System.EventHandler(this.неВыполненныеЗаданияToolStripMenuItem_Click);
            // 
            // отчетОбАктивностяхToolStripMenuItem
            // 
            this.отчетОбАктивностяхToolStripMenuItem.Name = "отчетОбАктивностяхToolStripMenuItem";
            this.отчетОбАктивностяхToolStripMenuItem.Size = new System.Drawing.Size(276, 26);
            this.отчетОбАктивностяхToolStripMenuItem.Text = "Отчет об активностях";
            this.отчетОбАктивностяхToolStripMenuItem.Click += new System.EventHandler(this.отчетОбАктивностяхToolStripMenuItem_Click);
            // 
            // заданияToolStripMenuItem
            // 
            this.заданияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.написаниеЗаданийToolStripMenuItem,
            this.просмотрАктивностейToolStripMenuItem,
            this.pdfviewerToolStripMenuItem});
            this.заданияToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.заданияToolStripMenuItem.Name = "заданияToolStripMenuItem";
            this.заданияToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.заданияToolStripMenuItem.Text = "Задания";
            // 
            // написаниеЗаданийToolStripMenuItem
            // 
            this.написаниеЗаданийToolStripMenuItem.Name = "написаниеЗаданийToolStripMenuItem";
            this.написаниеЗаданийToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.написаниеЗаданийToolStripMenuItem.Text = "Разработка заданий";
            this.написаниеЗаданийToolStripMenuItem.Click += new System.EventHandler(this.написаниеЗаданийToolStripMenuItem_Click);
            // 
            // просмотрАктивностейToolStripMenuItem
            // 
            this.просмотрАктивностейToolStripMenuItem.Name = "просмотрАктивностейToolStripMenuItem";
            this.просмотрАктивностейToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.просмотрАктивностейToolStripMenuItem.Text = "Просмотр активностей";
            this.просмотрАктивностейToolStripMenuItem.Click += new System.EventHandler(this.просмотрАктивностейToolStripMenuItem_Click);
            // 
            // администрированиеToolStripMenuItem
            // 
            this.администрированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пользователиToolStripMenuItem,
            this.справочникДолжностейToolStripMenuItem});
            this.администрированиеToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.администрированиеToolStripMenuItem.Name = "администрированиеToolStripMenuItem";
            this.администрированиеToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.администрированиеToolStripMenuItem.Text = "Администрирование";
            // 
            // пользователиToolStripMenuItem
            // 
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.пользователиToolStripMenuItem.Text = "Пользователи";
            this.пользователиToolStripMenuItem.Click += new System.EventHandler(this.пользователиToolStripMenuItem_Click);
            // 
            // справочникДолжностейToolStripMenuItem
            // 
            this.справочникДолжностейToolStripMenuItem.Name = "справочникДолжностейToolStripMenuItem";
            this.справочникДолжностейToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.справочникДолжностейToolStripMenuItem.Text = "Справочник должностей";
            this.справочникДолжностейToolStripMenuItem.Click += new System.EventHandler(this.справочникДолжностейToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 394);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(710, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pdfviewerToolStripMenuItem
            // 
            this.pdfviewerToolStripMenuItem.Name = "pdfviewerToolStripMenuItem";
            this.pdfviewerToolStripMenuItem.Size = new System.Drawing.Size(254, 26);
            this.pdfviewerToolStripMenuItem.Text = "Pdf_viewer";
            this.pdfviewerToolStripMenuItem.Click += new System.EventHandler(this.pdfviewerToolStripMenuItem_Click);
            // 
            // ГлавнаяРуководитель
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::Планировщик_рабочего_времени.Properties.Resources.Фон;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(710, 420);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ГлавнаяРуководитель";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ГлавнаяРуководитель_FormClosed);
            this.Load += new System.EventHandler(this.ГлавнаяРуководитель_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem заданияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem написаниеЗаданийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрАктивностейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem администрированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникДолжностейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem профильToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьПарольToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem неВыполненныеЗаданияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетОбАктивностяхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem телефонныйСправочникToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem открытьPdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pdfviewerToolStripMenuItem;
    }
}