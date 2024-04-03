namespace advancedCalculator2._0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button11 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.history_list = new System.Windows.Forms.ListBox();
            this.bt_sqr = new System.Windows.Forms.Button();
            this.bt_1delx = new System.Windows.Forms.Button();
            this.bt_sqrt = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.ravno = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.bt_div = new System.Windows.Forms.Button();
            this.bt_mul = new System.Windows.Forms.Button();
            this.bt_sub = new System.Windows.Forms.Button();
            this.bt_sum = new System.Windows.Forms.Button();
            this.hz = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.opLabel = new System.Windows.Forms.Label();
            this.toAdvanced = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(769, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button11.ForeColor = System.Drawing.Color.DarkRed;
            this.button11.Location = new System.Drawing.Point(432, 424);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(305, 57);
            this.button11.TabIndex = 57;
            this.button11.Text = "Очистить";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(534, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 56;
            this.label2.Text = "История";
            // 
            // history_list
            // 
            this.history_list.BackColor = System.Drawing.Color.White;
            this.history_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.history_list.ForeColor = System.Drawing.Color.DarkRed;
            this.history_list.FormattingEnabled = true;
            this.history_list.ItemHeight = 20;
            this.history_list.Location = new System.Drawing.Point(432, 99);
            this.history_list.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.history_list.Name = "history_list";
            this.history_list.Size = new System.Drawing.Size(305, 304);
            this.history_list.TabIndex = 55;
            this.history_list.MouseDown += new System.Windows.Forms.MouseEventHandler(this.history_list_MouseDown);
            // 
            // bt_sqr
            // 
            this.bt_sqr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_sqr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_sqr.ForeColor = System.Drawing.SystemColors.Window;
            this.bt_sqr.Location = new System.Drawing.Point(148, 163);
            this.bt_sqr.Margin = new System.Windows.Forms.Padding(4);
            this.bt_sqr.Name = "bt_sqr";
            this.bt_sqr.Size = new System.Drawing.Size(55, 57);
            this.bt_sqr.TabIndex = 54;
            this.bt_sqr.TabStop = false;
            this.bt_sqr.Tag = "5";
            this.bt_sqr.Text = "x^2";
            this.bt_sqr.UseVisualStyleBackColor = false;
            this.bt_sqr.Click += new System.EventHandler(this.UnaryOperationClick);
            // 
            // bt_1delx
            // 
            this.bt_1delx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_1delx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_1delx.ForeColor = System.Drawing.SystemColors.Window;
            this.bt_1delx.Location = new System.Drawing.Point(87, 163);
            this.bt_1delx.Margin = new System.Windows.Forms.Padding(4);
            this.bt_1delx.Name = "bt_1delx";
            this.bt_1delx.Size = new System.Drawing.Size(55, 57);
            this.bt_1delx.TabIndex = 53;
            this.bt_1delx.TabStop = false;
            this.bt_1delx.Tag = "6";
            this.bt_1delx.Text = "1/x";
            this.bt_1delx.UseVisualStyleBackColor = false;
            this.bt_1delx.Click += new System.EventHandler(this.UnaryOperationClick);
            // 
            // bt_sqrt
            // 
            this.bt_sqrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_sqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_sqrt.ForeColor = System.Drawing.SystemColors.Window;
            this.bt_sqrt.Location = new System.Drawing.Point(211, 163);
            this.bt_sqrt.Margin = new System.Windows.Forms.Padding(4);
            this.bt_sqrt.Name = "bt_sqrt";
            this.bt_sqrt.Size = new System.Drawing.Size(55, 57);
            this.bt_sqrt.TabIndex = 52;
            this.bt_sqrt.TabStop = false;
            this.bt_sqrt.Tag = "7";
            this.bt_sqrt.Text = "√x";
            this.bt_sqrt.UseVisualStyleBackColor = false;
            this.bt_sqrt.Click += new System.EventHandler(this.UnaryOperationClick);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.DarkRed;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button19.ForeColor = System.Drawing.SystemColors.Window;
            this.button19.Location = new System.Drawing.Point(24, 164);
            this.button19.Margin = new System.Windows.Forms.Padding(4);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(55, 57);
            this.button19.TabIndex = 51;
            this.button19.TabStop = false;
            this.button19.Text = "C";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.CClick);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button18.ForeColor = System.Drawing.SystemColors.Window;
            this.button18.Location = new System.Drawing.Point(274, 164);
            this.button18.Margin = new System.Windows.Forms.Padding(4);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(55, 57);
            this.button18.TabIndex = 50;
            this.button18.TabStop = false;
            this.button18.Text = "←";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.BackspaceClick);
            // 
            // ravno
            // 
            this.ravno.BackColor = System.Drawing.Color.Blue;
            this.ravno.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ravno.ForeColor = System.Drawing.SystemColors.Window;
            this.ravno.Location = new System.Drawing.Point(274, 424);
            this.ravno.Margin = new System.Windows.Forms.Padding(4);
            this.ravno.Name = "ravno";
            this.ravno.Size = new System.Drawing.Size(122, 57);
            this.ravno.TabIndex = 49;
            this.ravno.TabStop = false;
            this.ravno.Text = "=";
            this.ravno.UseVisualStyleBackColor = false;
            this.ravno.Click += new System.EventHandler(this.RavnoClick);
            // 
            // point
            // 
            this.point.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.point.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.point.ForeColor = System.Drawing.SystemColors.Window;
            this.point.Location = new System.Drawing.Point(24, 424);
            this.point.Margin = new System.Windows.Forms.Padding(4);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(55, 57);
            this.point.TabIndex = 48;
            this.point.TabStop = false;
            this.point.Text = ",";
            this.point.UseVisualStyleBackColor = false;
            this.point.Click += new System.EventHandler(this.pointClick);
            // 
            // bt_div
            // 
            this.bt_div.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_div.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_div.ForeColor = System.Drawing.SystemColors.Window;
            this.bt_div.Location = new System.Drawing.Point(341, 164);
            this.bt_div.Margin = new System.Windows.Forms.Padding(4);
            this.bt_div.Name = "bt_div";
            this.bt_div.Size = new System.Drawing.Size(55, 57);
            this.bt_div.TabIndex = 47;
            this.bt_div.TabStop = false;
            this.bt_div.Tag = "4";
            this.bt_div.Text = "/";
            this.bt_div.UseVisualStyleBackColor = false;
            this.bt_div.Click += new System.EventHandler(this.OperationClick);
            // 
            // bt_mul
            // 
            this.bt_mul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_mul.ForeColor = System.Drawing.SystemColors.Window;
            this.bt_mul.Location = new System.Drawing.Point(341, 229);
            this.bt_mul.Margin = new System.Windows.Forms.Padding(4);
            this.bt_mul.Name = "bt_mul";
            this.bt_mul.Size = new System.Drawing.Size(55, 57);
            this.bt_mul.TabIndex = 46;
            this.bt_mul.TabStop = false;
            this.bt_mul.Tag = "3";
            this.bt_mul.Text = "х";
            this.bt_mul.UseVisualStyleBackColor = false;
            this.bt_mul.Click += new System.EventHandler(this.OperationClick);
            // 
            // bt_sub
            // 
            this.bt_sub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_sub.ForeColor = System.Drawing.SystemColors.Window;
            this.bt_sub.Location = new System.Drawing.Point(341, 294);
            this.bt_sub.Margin = new System.Windows.Forms.Padding(4);
            this.bt_sub.Name = "bt_sub";
            this.bt_sub.Size = new System.Drawing.Size(55, 57);
            this.bt_sub.TabIndex = 45;
            this.bt_sub.TabStop = false;
            this.bt_sub.Tag = "2";
            this.bt_sub.Text = "-";
            this.bt_sub.UseVisualStyleBackColor = false;
            this.bt_sub.Click += new System.EventHandler(this.OperationClick);
            // 
            // bt_sum
            // 
            this.bt_sum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_sum.ForeColor = System.Drawing.SystemColors.Window;
            this.bt_sum.Location = new System.Drawing.Point(341, 359);
            this.bt_sum.Margin = new System.Windows.Forms.Padding(4);
            this.bt_sum.Name = "bt_sum";
            this.bt_sum.Size = new System.Drawing.Size(55, 57);
            this.bt_sum.TabIndex = 44;
            this.bt_sum.TabStop = false;
            this.bt_sum.Tag = "1";
            this.bt_sum.Text = "+";
            this.bt_sum.UseVisualStyleBackColor = false;
            this.bt_sum.Click += new System.EventHandler(this.OperationClick);
            // 
            // hz
            // 
            this.hz.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.hz.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hz.ForeColor = System.Drawing.SystemColors.Window;
            this.hz.Location = new System.Drawing.Point(87, 424);
            this.hz.Margin = new System.Windows.Forms.Padding(4);
            this.hz.Name = "hz";
            this.hz.Size = new System.Drawing.Size(55, 57);
            this.hz.TabIndex = 43;
            this.hz.TabStop = false;
            this.hz.Text = "±";
            this.hz.UseVisualStyleBackColor = false;
            this.hz.Click += new System.EventHandler(this.hz_click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.Menu;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button10.Location = new System.Drawing.Point(152, 424);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(114, 57);
            this.button10.TabIndex = 42;
            this.button10.TabStop = false;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.DigitClick);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Menu;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button7.Location = new System.Drawing.Point(274, 229);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(55, 57);
            this.button7.TabIndex = 41;
            this.button7.TabStop = false;
            this.button7.Text = "9";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.DigitClick);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.Menu;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button8.Location = new System.Drawing.Point(152, 229);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(114, 57);
            this.button8.TabIndex = 40;
            this.button8.TabStop = false;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.DigitClick);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.Menu;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button9.Location = new System.Drawing.Point(24, 229);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(120, 57);
            this.button9.TabIndex = 39;
            this.button9.TabStop = false;
            this.button9.Text = "7";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.DigitClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Menu;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button4.Location = new System.Drawing.Point(274, 294);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 57);
            this.button4.TabIndex = 38;
            this.button4.TabStop = false;
            this.button4.Text = "6";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.DigitClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Menu;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button5.Location = new System.Drawing.Point(152, 294);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 57);
            this.button5.TabIndex = 37;
            this.button5.TabStop = false;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.DigitClick);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Menu;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button6.Location = new System.Drawing.Point(24, 294);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 57);
            this.button6.TabIndex = 36;
            this.button6.TabStop = false;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.DigitClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Menu;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button3.Location = new System.Drawing.Point(274, 359);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 57);
            this.button3.TabIndex = 35;
            this.button3.TabStop = false;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.DigitClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Menu;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(152, 359);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 57);
            this.button2.TabIndex = 34;
            this.button2.TabStop = false;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.DigitClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(24, 359);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 57);
            this.button1.TabIndex = 33;
            this.button1.TabStop = false;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.DigitClick);
            // 
            // resultLabel
            // 
            this.resultLabel.AllowDrop = true;
            this.resultLabel.BackColor = System.Drawing.Color.White;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.ForeColor = System.Drawing.Color.Black;
            this.resultLabel.Location = new System.Drawing.Point(24, 99);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(372, 46);
            this.resultLabel.TabIndex = 32;
            this.resultLabel.Text = "0";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resultLabel.DragDrop += new System.Windows.Forms.DragEventHandler(this.resultLabel_DragDrop);
            this.resultLabel.DragOver += new System.Windows.Forms.DragEventHandler(this.resultLabel_DragOver);
            // 
            // opLabel
            // 
            this.opLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.opLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.opLabel.Location = new System.Drawing.Point(113, 49);
            this.opLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.opLabel.Name = "opLabel";
            this.opLabel.Size = new System.Drawing.Size(283, 39);
            this.opLabel.TabIndex = 31;
            this.opLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toAdvanced
            // 
            this.toAdvanced.BackColor = System.Drawing.Color.DarkRed;
            this.toAdvanced.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toAdvanced.ForeColor = System.Drawing.SystemColors.Window;
            this.toAdvanced.Location = new System.Drawing.Point(24, 49);
            this.toAdvanced.Margin = new System.Windows.Forms.Padding(4);
            this.toAdvanced.Name = "toAdvanced";
            this.toAdvanced.Size = new System.Drawing.Size(81, 46);
            this.toAdvanced.TabIndex = 58;
            this.toAdvanced.TabStop = false;
            this.toAdvanced.Text = "=>";
            this.toAdvanced.UseVisualStyleBackColor = false;
            this.toAdvanced.Click += new System.EventHandler(this.toAdvancedClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(769, 500);
            this.Controls.Add(this.toAdvanced);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.history_list);
            this.Controls.Add(this.bt_sqr);
            this.Controls.Add(this.bt_1delx);
            this.Controls.Add(this.bt_sqrt);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.ravno);
            this.Controls.Add(this.point);
            this.Controls.Add(this.bt_div);
            this.Controls.Add(this.bt_mul);
            this.Controls.Add(this.bt_sub);
            this.Controls.Add(this.bt_sum);
            this.Controls.Add(this.hz);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.opLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox history_list;
        private System.Windows.Forms.Button bt_sqr;
        private System.Windows.Forms.Button bt_1delx;
        private System.Windows.Forms.Button bt_sqrt;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button ravno;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button bt_div;
        private System.Windows.Forms.Button bt_mul;
        private System.Windows.Forms.Button bt_sub;
        private System.Windows.Forms.Button bt_sum;
        private System.Windows.Forms.Button hz;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label opLabel;
        private System.Windows.Forms.Button toAdvanced;
    }
}

