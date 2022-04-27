
namespace mytools
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges13 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges14 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges15 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges16 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges17 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges18 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.notepadclear = new System.Windows.Forms.ToolStripMenuItem();
            this.adddate = new System.Windows.Forms.ToolStripMenuItem();
            this.addtime = new System.Windows.Forms.ToolStripMenuItem();
            this.addscoreandtime = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.notepadsave = new System.Windows.Forms.ToolStripMenuItem();
            this.notepadload = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.играToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запуститьИгруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pluscount = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.notepad = new System.Windows.Forms.TabPage();
            this.notepadwrite = new System.Windows.Forms.RichTextBox();
            this.counter = new System.Windows.Forms.TabPage();
            this.minuscount = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.resetcount = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.plusscount = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.generator = new System.Windows.Forms.TabPage();
            this.startgenerator = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.scoregenerator = new System.Windows.Forms.Label();
            this.mingenerator = new System.Windows.Forms.Label();
            this.maxgenerator = new System.Windows.Forms.Label();
            this.minvaluegen = new System.Windows.Forms.NumericUpDown();
            this.maxvaluegen = new System.Windows.Forms.NumericUpDown();
            this.Textboxrandm = new System.Windows.Forms.TextBox();
            this.clearbutton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.passwordtool = new System.Windows.Forms.TabPage();
            this.checkedListpass = new System.Windows.Forms.CheckedListBox();
            this.lengthpass = new System.Windows.Forms.Label();
            this.numericupdownpass = new System.Windows.Forms.NumericUpDown();
            this.createpass = new System.Windows.Forms.Button();
            this.textBoxpass = new System.Windows.Forms.TextBox();
            this.buttonclear = new System.Windows.Forms.Button();
            this.copybutpass = new System.Windows.Forms.Button();
            this.scoretool = new System.Windows.Forms.TabControl();
            this.scorecount = new Bunifu.UI.WinForms.BunifuLabel();
            this.подробнееОбУтилитахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подробнееОИгреToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.notepad.SuspendLayout();
            this.counter.SuspendLayout();
            this.generator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minvaluegen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxvaluegen)).BeginInit();
            this.passwordtool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericupdownpass)).BeginInit();
            this.scoretool.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.notepadclear,
            this.играToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem1,
            this.подробнееОбУтилитахToolStripMenuItem,
            this.подробнееОИгреToolStripMenuItem});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.оПрограммеToolStripMenuItem.Text = "Помощь";
            // 
            // оПрограммеToolStripMenuItem1
            // 
            this.оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            this.оПрограммеToolStripMenuItem1.Size = new System.Drawing.Size(187, 26);
            this.оПрограммеToolStripMenuItem1.Text = "О программе";
            this.оПрограммеToolStripMenuItem1.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem1_Click);
            // 
            // notepadclear
            // 
            this.notepadclear.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adddate,
            this.addtime,
            this.addscoreandtime,
            this.toolStripMenuItem1,
            this.notepadsave,
            this.notepadload,
            this.очиститьToolStripMenuItem});
            this.notepadclear.Name = "notepadclear";
            this.notepadclear.Size = new System.Drawing.Size(80, 24);
            this.notepadclear.Text = "Блокнот";
            // 
            // adddate
            // 
            this.adddate.Name = "adddate";
            this.adddate.Size = new System.Drawing.Size(253, 26);
            this.adddate.Text = "Добавить дату";
            this.adddate.Click += new System.EventHandler(this.вставитьДатуToolStripMenuItem_Click);
            // 
            // addtime
            // 
            this.addtime.Name = "addtime";
            this.addtime.Size = new System.Drawing.Size(253, 26);
            this.addtime.Text = "Добавить время";
            this.addtime.Click += new System.EventHandler(this.addtime_Click);
            // 
            // addscoreandtime
            // 
            this.addscoreandtime.Name = "addscoreandtime";
            this.addscoreandtime.Size = new System.Drawing.Size(253, 26);
            this.addscoreandtime.Text = "Добавить дату и время";
            this.addscoreandtime.Click += new System.EventHandler(this.addscoreandtime_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(250, 6);
            // 
            // notepadsave
            // 
            this.notepadsave.Name = "notepadsave";
            this.notepadsave.Size = new System.Drawing.Size(253, 26);
            this.notepadsave.Text = "Сохранить";
            this.notepadsave.Click += new System.EventHandler(this.notepadsave_Click);
            // 
            // notepadload
            // 
            this.notepadload.Name = "notepadload";
            this.notepadload.Size = new System.Drawing.Size(253, 26);
            this.notepadload.Text = "Загрузить";
            this.notepadload.Click += new System.EventHandler(this.notepadload_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // играToolStripMenuItem
            // 
            this.играToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запуститьИгруToolStripMenuItem});
            this.играToolStripMenuItem.Name = "играToolStripMenuItem";
            this.играToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.играToolStripMenuItem.Text = "Игра";
            // 
            // запуститьИгруToolStripMenuItem
            // 
            this.запуститьИгруToolStripMenuItem.Name = "запуститьИгруToolStripMenuItem";
            this.запуститьИгруToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.запуститьИгруToolStripMenuItem.Text = "Запустить игру";
            this.запуститьИгруToolStripMenuItem.Click += new System.EventHandler(this.запуститьИгруToolStripMenuItem_Click);
            // 
            // pluscount
            // 
            this.pluscount.AllowAnimations = true;
            this.pluscount.AllowMouseEffects = true;
            this.pluscount.AllowToggling = false;
            this.pluscount.AnimationSpeed = 200;
            this.pluscount.AutoGenerateColors = false;
            this.pluscount.AutoRoundBorders = false;
            this.pluscount.AutoSizeLeftIcon = true;
            this.pluscount.AutoSizeRightIcon = true;
            this.pluscount.BackColor = System.Drawing.Color.Transparent;
            this.pluscount.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.pluscount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pluscount.BackgroundImage")));
            this.pluscount.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.pluscount.ButtonText = "+";
            this.pluscount.ButtonTextMarginLeft = 0;
            this.pluscount.ColorContrastOnClick = 45;
            this.pluscount.ColorContrastOnHover = 45;
            this.pluscount.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges13.BottomLeft = true;
            borderEdges13.BottomRight = true;
            borderEdges13.TopLeft = true;
            borderEdges13.TopRight = true;
            this.pluscount.CustomizableEdges = borderEdges13;
            this.pluscount.DialogResult = System.Windows.Forms.DialogResult.None;
            this.pluscount.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.pluscount.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.pluscount.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.pluscount.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.pluscount.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pluscount.ForeColor = System.Drawing.Color.White;
            this.pluscount.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pluscount.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.pluscount.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.pluscount.IconMarginLeft = 11;
            this.pluscount.IconPadding = 10;
            this.pluscount.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pluscount.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.pluscount.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.pluscount.IconSize = 25;
            this.pluscount.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.pluscount.IdleBorderRadius = 1;
            this.pluscount.IdleBorderThickness = 1;
            this.pluscount.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.pluscount.IdleIconLeftImage = null;
            this.pluscount.IdleIconRightImage = null;
            this.pluscount.IndicateFocus = false;
            this.pluscount.Location = new System.Drawing.Point(190, 49);
            this.pluscount.Name = "pluscount";
            this.pluscount.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.pluscount.OnDisabledState.BorderRadius = 1;
            this.pluscount.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.pluscount.OnDisabledState.BorderThickness = 1;
            this.pluscount.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.pluscount.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.pluscount.OnDisabledState.IconLeftImage = null;
            this.pluscount.OnDisabledState.IconRightImage = null;
            this.pluscount.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.pluscount.onHoverState.BorderRadius = 1;
            this.pluscount.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.pluscount.onHoverState.BorderThickness = 1;
            this.pluscount.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.pluscount.onHoverState.ForeColor = System.Drawing.Color.White;
            this.pluscount.onHoverState.IconLeftImage = null;
            this.pluscount.onHoverState.IconRightImage = null;
            this.pluscount.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.pluscount.OnIdleState.BorderRadius = 1;
            this.pluscount.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.pluscount.OnIdleState.BorderThickness = 1;
            this.pluscount.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.pluscount.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.pluscount.OnIdleState.IconLeftImage = null;
            this.pluscount.OnIdleState.IconRightImage = null;
            this.pluscount.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.pluscount.OnPressedState.BorderRadius = 1;
            this.pluscount.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.pluscount.OnPressedState.BorderThickness = 1;
            this.pluscount.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.pluscount.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.pluscount.OnPressedState.IconLeftImage = null;
            this.pluscount.OnPressedState.IconRightImage = null;
            this.pluscount.Size = new System.Drawing.Size(150, 67);
            this.pluscount.TabIndex = 1;
            this.pluscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pluscount.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.pluscount.TextMarginLeft = 0;
            this.pluscount.TextPadding = new System.Windows.Forms.Padding(0);
            this.pluscount.UseDefaultRadiusAndThickness = true;
            // 
            // notepad
            // 
            this.notepad.Controls.Add(this.notepadwrite);
            this.notepad.Location = new System.Drawing.Point(4, 25);
            this.notepad.Name = "notepad";
            this.notepad.Size = new System.Drawing.Size(792, 391);
            this.notepad.TabIndex = 2;
            this.notepad.Text = "Блокнот";
            this.notepad.UseVisualStyleBackColor = true;
            // 
            // notepadwrite
            // 
            this.notepadwrite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notepadwrite.Location = new System.Drawing.Point(0, 0);
            this.notepadwrite.Name = "notepadwrite";
            this.notepadwrite.Size = new System.Drawing.Size(792, 391);
            this.notepadwrite.TabIndex = 0;
            this.notepadwrite.Text = "";
            // 
            // counter
            // 
            this.counter.Controls.Add(this.plusscount);
            this.counter.Controls.Add(this.scorecount);
            this.counter.Controls.Add(this.resetcount);
            this.counter.Controls.Add(this.minuscount);
            this.counter.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counter.Location = new System.Drawing.Point(4, 25);
            this.counter.Name = "counter";
            this.counter.Padding = new System.Windows.Forms.Padding(3);
            this.counter.Size = new System.Drawing.Size(792, 391);
            this.counter.TabIndex = 0;
            this.counter.Text = "Счетчик";
            this.counter.UseVisualStyleBackColor = true;
            // 
            // minuscount
            // 
            this.minuscount.AllowAnimations = true;
            this.minuscount.AllowMouseEffects = true;
            this.minuscount.AllowToggling = false;
            this.minuscount.AnimationSpeed = 200;
            this.minuscount.AutoGenerateColors = false;
            this.minuscount.AutoRoundBorders = false;
            this.minuscount.AutoSizeLeftIcon = true;
            this.minuscount.AutoSizeRightIcon = true;
            this.minuscount.BackColor = System.Drawing.Color.Transparent;
            this.minuscount.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.minuscount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minuscount.BackgroundImage")));
            this.minuscount.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.minuscount.ButtonText = "-";
            this.minuscount.ButtonTextMarginLeft = 0;
            this.minuscount.ColorContrastOnClick = 45;
            this.minuscount.ColorContrastOnHover = 45;
            this.minuscount.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges14.BottomLeft = true;
            borderEdges14.BottomRight = true;
            borderEdges14.TopLeft = true;
            borderEdges14.TopRight = true;
            this.minuscount.CustomizableEdges = borderEdges14;
            this.minuscount.DialogResult = System.Windows.Forms.DialogResult.None;
            this.minuscount.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.minuscount.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.minuscount.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.minuscount.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.minuscount.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minuscount.ForeColor = System.Drawing.Color.White;
            this.minuscount.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.minuscount.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.minuscount.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.minuscount.IconMarginLeft = 11;
            this.minuscount.IconPadding = 10;
            this.minuscount.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.minuscount.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.minuscount.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.minuscount.IconSize = 25;
            this.minuscount.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.minuscount.IdleBorderRadius = 1;
            this.minuscount.IdleBorderThickness = 1;
            this.minuscount.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.minuscount.IdleIconLeftImage = null;
            this.minuscount.IdleIconRightImage = null;
            this.minuscount.IndicateFocus = false;
            this.minuscount.Location = new System.Drawing.Point(190, 253);
            this.minuscount.Name = "minuscount";
            this.minuscount.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.minuscount.OnDisabledState.BorderRadius = 1;
            this.minuscount.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.minuscount.OnDisabledState.BorderThickness = 1;
            this.minuscount.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.minuscount.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.minuscount.OnDisabledState.IconLeftImage = null;
            this.minuscount.OnDisabledState.IconRightImage = null;
            this.minuscount.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.minuscount.onHoverState.BorderRadius = 1;
            this.minuscount.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.minuscount.onHoverState.BorderThickness = 1;
            this.minuscount.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.minuscount.onHoverState.ForeColor = System.Drawing.Color.White;
            this.minuscount.onHoverState.IconLeftImage = null;
            this.minuscount.onHoverState.IconRightImage = null;
            this.minuscount.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.minuscount.OnIdleState.BorderRadius = 1;
            this.minuscount.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.minuscount.OnIdleState.BorderThickness = 1;
            this.minuscount.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.minuscount.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.minuscount.OnIdleState.IconLeftImage = null;
            this.minuscount.OnIdleState.IconRightImage = null;
            this.minuscount.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.minuscount.OnPressedState.BorderRadius = 1;
            this.minuscount.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.minuscount.OnPressedState.BorderThickness = 1;
            this.minuscount.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.minuscount.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.minuscount.OnPressedState.IconLeftImage = null;
            this.minuscount.OnPressedState.IconRightImage = null;
            this.minuscount.Size = new System.Drawing.Size(150, 67);
            this.minuscount.TabIndex = 2;
            this.minuscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.minuscount.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.minuscount.TextMarginLeft = 0;
            this.minuscount.TextPadding = new System.Windows.Forms.Padding(0);
            this.minuscount.UseDefaultRadiusAndThickness = true;
            this.minuscount.Click += new System.EventHandler(this.minuscount_Click);
            // 
            // resetcount
            // 
            this.resetcount.AllowAnimations = true;
            this.resetcount.AllowMouseEffects = true;
            this.resetcount.AllowToggling = false;
            this.resetcount.AnimationSpeed = 200;
            this.resetcount.AutoGenerateColors = false;
            this.resetcount.AutoRoundBorders = false;
            this.resetcount.AutoSizeLeftIcon = true;
            this.resetcount.AutoSizeRightIcon = true;
            this.resetcount.BackColor = System.Drawing.Color.Transparent;
            this.resetcount.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.resetcount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resetcount.BackgroundImage")));
            this.resetcount.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.resetcount.ButtonText = "Сброс";
            this.resetcount.ButtonTextMarginLeft = 0;
            this.resetcount.ColorContrastOnClick = 45;
            this.resetcount.ColorContrastOnHover = 45;
            this.resetcount.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges15.BottomLeft = true;
            borderEdges15.BottomRight = true;
            borderEdges15.TopLeft = true;
            borderEdges15.TopRight = true;
            this.resetcount.CustomizableEdges = borderEdges15;
            this.resetcount.DialogResult = System.Windows.Forms.DialogResult.None;
            this.resetcount.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.resetcount.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.resetcount.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.resetcount.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.resetcount.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetcount.ForeColor = System.Drawing.Color.White;
            this.resetcount.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resetcount.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.resetcount.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.resetcount.IconMarginLeft = 11;
            this.resetcount.IconPadding = 10;
            this.resetcount.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resetcount.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.resetcount.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.resetcount.IconSize = 25;
            this.resetcount.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.resetcount.IdleBorderRadius = 1;
            this.resetcount.IdleBorderThickness = 1;
            this.resetcount.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.resetcount.IdleIconLeftImage = null;
            this.resetcount.IdleIconRightImage = null;
            this.resetcount.IndicateFocus = false;
            this.resetcount.Location = new System.Drawing.Point(400, 147);
            this.resetcount.Name = "resetcount";
            this.resetcount.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.resetcount.OnDisabledState.BorderRadius = 1;
            this.resetcount.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.resetcount.OnDisabledState.BorderThickness = 1;
            this.resetcount.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.resetcount.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.resetcount.OnDisabledState.IconLeftImage = null;
            this.resetcount.OnDisabledState.IconRightImage = null;
            this.resetcount.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.resetcount.onHoverState.BorderRadius = 1;
            this.resetcount.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.resetcount.onHoverState.BorderThickness = 1;
            this.resetcount.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.resetcount.onHoverState.ForeColor = System.Drawing.Color.White;
            this.resetcount.onHoverState.IconLeftImage = null;
            this.resetcount.onHoverState.IconRightImage = null;
            this.resetcount.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.resetcount.OnIdleState.BorderRadius = 1;
            this.resetcount.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.resetcount.OnIdleState.BorderThickness = 1;
            this.resetcount.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.resetcount.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.resetcount.OnIdleState.IconLeftImage = null;
            this.resetcount.OnIdleState.IconRightImage = null;
            this.resetcount.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.resetcount.OnPressedState.BorderRadius = 1;
            this.resetcount.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.resetcount.OnPressedState.BorderThickness = 1;
            this.resetcount.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.resetcount.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.resetcount.OnPressedState.IconLeftImage = null;
            this.resetcount.OnPressedState.IconRightImage = null;
            this.resetcount.Size = new System.Drawing.Size(150, 67);
            this.resetcount.TabIndex = 3;
            this.resetcount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resetcount.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.resetcount.TextMarginLeft = 0;
            this.resetcount.TextPadding = new System.Windows.Forms.Padding(0);
            this.resetcount.UseDefaultRadiusAndThickness = true;
            this.resetcount.Click += new System.EventHandler(this.resetcount_Click);
            // 
            // plusscount
            // 
            this.plusscount.AllowAnimations = true;
            this.plusscount.AllowMouseEffects = true;
            this.plusscount.AllowToggling = false;
            this.plusscount.AnimationSpeed = 200;
            this.plusscount.AutoGenerateColors = false;
            this.plusscount.AutoRoundBorders = false;
            this.plusscount.AutoSizeLeftIcon = true;
            this.plusscount.AutoSizeRightIcon = true;
            this.plusscount.BackColor = System.Drawing.Color.Transparent;
            this.plusscount.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.plusscount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plusscount.BackgroundImage")));
            this.plusscount.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.plusscount.ButtonText = "+";
            this.plusscount.ButtonTextMarginLeft = 0;
            this.plusscount.ColorContrastOnClick = 45;
            this.plusscount.ColorContrastOnHover = 45;
            this.plusscount.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges16.BottomLeft = true;
            borderEdges16.BottomRight = true;
            borderEdges16.TopLeft = true;
            borderEdges16.TopRight = true;
            this.plusscount.CustomizableEdges = borderEdges16;
            this.plusscount.DialogResult = System.Windows.Forms.DialogResult.None;
            this.plusscount.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.plusscount.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.plusscount.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.plusscount.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.plusscount.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusscount.ForeColor = System.Drawing.Color.White;
            this.plusscount.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.plusscount.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.plusscount.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.plusscount.IconMarginLeft = 11;
            this.plusscount.IconPadding = 10;
            this.plusscount.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.plusscount.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.plusscount.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.plusscount.IconSize = 25;
            this.plusscount.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.plusscount.IdleBorderRadius = 1;
            this.plusscount.IdleBorderThickness = 1;
            this.plusscount.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.plusscount.IdleIconLeftImage = null;
            this.plusscount.IdleIconRightImage = null;
            this.plusscount.IndicateFocus = false;
            this.plusscount.Location = new System.Drawing.Point(190, 57);
            this.plusscount.Name = "plusscount";
            this.plusscount.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.plusscount.OnDisabledState.BorderRadius = 1;
            this.plusscount.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.plusscount.OnDisabledState.BorderThickness = 1;
            this.plusscount.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.plusscount.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.plusscount.OnDisabledState.IconLeftImage = null;
            this.plusscount.OnDisabledState.IconRightImage = null;
            this.plusscount.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.plusscount.onHoverState.BorderRadius = 1;
            this.plusscount.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.plusscount.onHoverState.BorderThickness = 1;
            this.plusscount.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.plusscount.onHoverState.ForeColor = System.Drawing.Color.White;
            this.plusscount.onHoverState.IconLeftImage = null;
            this.plusscount.onHoverState.IconRightImage = null;
            this.plusscount.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.plusscount.OnIdleState.BorderRadius = 1;
            this.plusscount.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.plusscount.OnIdleState.BorderThickness = 1;
            this.plusscount.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.plusscount.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.plusscount.OnIdleState.IconLeftImage = null;
            this.plusscount.OnIdleState.IconRightImage = null;
            this.plusscount.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.plusscount.OnPressedState.BorderRadius = 1;
            this.plusscount.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.plusscount.OnPressedState.BorderThickness = 1;
            this.plusscount.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.plusscount.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.plusscount.OnPressedState.IconLeftImage = null;
            this.plusscount.OnPressedState.IconRightImage = null;
            this.plusscount.Size = new System.Drawing.Size(150, 67);
            this.plusscount.TabIndex = 5;
            this.plusscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.plusscount.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.plusscount.TextMarginLeft = 0;
            this.plusscount.TextPadding = new System.Windows.Forms.Padding(0);
            this.plusscount.UseDefaultRadiusAndThickness = true;
            this.plusscount.Click += new System.EventHandler(this.plusscount_Click);
            // 
            // generator
            // 
            this.generator.Controls.Add(this.clearbutton);
            this.generator.Controls.Add(this.Textboxrandm);
            this.generator.Controls.Add(this.maxvaluegen);
            this.generator.Controls.Add(this.minvaluegen);
            this.generator.Controls.Add(this.maxgenerator);
            this.generator.Controls.Add(this.mingenerator);
            this.generator.Controls.Add(this.scoregenerator);
            this.generator.Controls.Add(this.startgenerator);
            this.generator.Location = new System.Drawing.Point(4, 25);
            this.generator.Name = "generator";
            this.generator.Padding = new System.Windows.Forms.Padding(3);
            this.generator.Size = new System.Drawing.Size(792, 391);
            this.generator.TabIndex = 1;
            this.generator.Text = "Генератор";
            this.generator.UseVisualStyleBackColor = true;
            // 
            // startgenerator
            // 
            this.startgenerator.AllowAnimations = true;
            this.startgenerator.AllowMouseEffects = true;
            this.startgenerator.AllowToggling = false;
            this.startgenerator.AnimationSpeed = 200;
            this.startgenerator.AutoGenerateColors = false;
            this.startgenerator.AutoRoundBorders = false;
            this.startgenerator.AutoSizeLeftIcon = true;
            this.startgenerator.AutoSizeRightIcon = true;
            this.startgenerator.BackColor = System.Drawing.Color.Transparent;
            this.startgenerator.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.startgenerator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("startgenerator.BackgroundImage")));
            this.startgenerator.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.startgenerator.ButtonText = "Сгенерировать";
            this.startgenerator.ButtonTextMarginLeft = 0;
            this.startgenerator.ColorContrastOnClick = 45;
            this.startgenerator.ColorContrastOnHover = 45;
            this.startgenerator.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges17.BottomLeft = true;
            borderEdges17.BottomRight = true;
            borderEdges17.TopLeft = true;
            borderEdges17.TopRight = true;
            this.startgenerator.CustomizableEdges = borderEdges17;
            this.startgenerator.DialogResult = System.Windows.Forms.DialogResult.None;
            this.startgenerator.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.startgenerator.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.startgenerator.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.startgenerator.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.startgenerator.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.startgenerator.ForeColor = System.Drawing.Color.White;
            this.startgenerator.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startgenerator.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.startgenerator.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.startgenerator.IconMarginLeft = 11;
            this.startgenerator.IconPadding = 10;
            this.startgenerator.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.startgenerator.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.startgenerator.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.startgenerator.IconSize = 25;
            this.startgenerator.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.startgenerator.IdleBorderRadius = 1;
            this.startgenerator.IdleBorderThickness = 1;
            this.startgenerator.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.startgenerator.IdleIconLeftImage = null;
            this.startgenerator.IdleIconRightImage = null;
            this.startgenerator.IndicateFocus = false;
            this.startgenerator.Location = new System.Drawing.Point(40, 157);
            this.startgenerator.Name = "startgenerator";
            this.startgenerator.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.startgenerator.OnDisabledState.BorderRadius = 1;
            this.startgenerator.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.startgenerator.OnDisabledState.BorderThickness = 1;
            this.startgenerator.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.startgenerator.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.startgenerator.OnDisabledState.IconLeftImage = null;
            this.startgenerator.OnDisabledState.IconRightImage = null;
            this.startgenerator.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.startgenerator.onHoverState.BorderRadius = 1;
            this.startgenerator.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.startgenerator.onHoverState.BorderThickness = 1;
            this.startgenerator.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.startgenerator.onHoverState.ForeColor = System.Drawing.Color.White;
            this.startgenerator.onHoverState.IconLeftImage = null;
            this.startgenerator.onHoverState.IconRightImage = null;
            this.startgenerator.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.startgenerator.OnIdleState.BorderRadius = 1;
            this.startgenerator.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.startgenerator.OnIdleState.BorderThickness = 1;
            this.startgenerator.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.startgenerator.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.startgenerator.OnIdleState.IconLeftImage = null;
            this.startgenerator.OnIdleState.IconRightImage = null;
            this.startgenerator.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.startgenerator.OnPressedState.BorderRadius = 1;
            this.startgenerator.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.startgenerator.OnPressedState.BorderThickness = 1;
            this.startgenerator.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.startgenerator.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.startgenerator.OnPressedState.IconLeftImage = null;
            this.startgenerator.OnPressedState.IconRightImage = null;
            this.startgenerator.Size = new System.Drawing.Size(169, 49);
            this.startgenerator.TabIndex = 0;
            this.startgenerator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.startgenerator.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.startgenerator.TextMarginLeft = 0;
            this.startgenerator.TextPadding = new System.Windows.Forms.Padding(0);
            this.startgenerator.UseDefaultRadiusAndThickness = true;
            this.startgenerator.Click += new System.EventHandler(this.startgenerator_Click);
            // 
            // scoregenerator
            // 
            this.scoregenerator.AutoSize = true;
            this.scoregenerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoregenerator.Location = new System.Drawing.Point(74, 244);
            this.scoregenerator.Name = "scoregenerator";
            this.scoregenerator.Size = new System.Drawing.Size(87, 95);
            this.scoregenerator.TabIndex = 1;
            this.scoregenerator.Text = "0";
            // 
            // mingenerator
            // 
            this.mingenerator.AutoSize = true;
            this.mingenerator.Location = new System.Drawing.Point(8, 33);
            this.mingenerator.Name = "mingenerator";
            this.mingenerator.Size = new System.Drawing.Size(26, 17);
            this.mingenerator.TabIndex = 2;
            this.mingenerator.Text = "От";
            // 
            // maxgenerator
            // 
            this.maxgenerator.AutoSize = true;
            this.maxgenerator.Location = new System.Drawing.Point(8, 86);
            this.maxgenerator.Name = "maxgenerator";
            this.maxgenerator.Size = new System.Drawing.Size(27, 17);
            this.maxgenerator.TabIndex = 3;
            this.maxgenerator.Text = "До";
            // 
            // minvaluegen
            // 
            this.minvaluegen.Location = new System.Drawing.Point(93, 36);
            this.minvaluegen.Name = "minvaluegen";
            this.minvaluegen.Size = new System.Drawing.Size(136, 22);
            this.minvaluegen.TabIndex = 4;
            // 
            // maxvaluegen
            // 
            this.maxvaluegen.Location = new System.Drawing.Point(93, 84);
            this.maxvaluegen.Name = "maxvaluegen";
            this.maxvaluegen.Size = new System.Drawing.Size(136, 22);
            this.maxvaluegen.TabIndex = 5;
            // 
            // Textboxrandm
            // 
            this.Textboxrandm.Location = new System.Drawing.Point(333, 35);
            this.Textboxrandm.Multiline = true;
            this.Textboxrandm.Name = "Textboxrandm";
            this.Textboxrandm.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Textboxrandm.Size = new System.Drawing.Size(210, 181);
            this.Textboxrandm.TabIndex = 6;
            // 
            // clearbutton
            // 
            this.clearbutton.AllowAnimations = true;
            this.clearbutton.AllowMouseEffects = true;
            this.clearbutton.AllowToggling = false;
            this.clearbutton.AnimationSpeed = 200;
            this.clearbutton.AutoGenerateColors = false;
            this.clearbutton.AutoRoundBorders = false;
            this.clearbutton.AutoSizeLeftIcon = true;
            this.clearbutton.AutoSizeRightIcon = true;
            this.clearbutton.BackColor = System.Drawing.Color.Transparent;
            this.clearbutton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.clearbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clearbutton.BackgroundImage")));
            this.clearbutton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.clearbutton.ButtonText = "Очистить";
            this.clearbutton.ButtonTextMarginLeft = 0;
            this.clearbutton.ColorContrastOnClick = 45;
            this.clearbutton.ColorContrastOnHover = 45;
            this.clearbutton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges18.BottomLeft = true;
            borderEdges18.BottomRight = true;
            borderEdges18.TopLeft = true;
            borderEdges18.TopRight = true;
            this.clearbutton.CustomizableEdges = borderEdges18;
            this.clearbutton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.clearbutton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.clearbutton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.clearbutton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.clearbutton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.clearbutton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.clearbutton.ForeColor = System.Drawing.Color.White;
            this.clearbutton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearbutton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.clearbutton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.clearbutton.IconMarginLeft = 11;
            this.clearbutton.IconPadding = 10;
            this.clearbutton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clearbutton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.clearbutton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.clearbutton.IconSize = 25;
            this.clearbutton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.clearbutton.IdleBorderRadius = 1;
            this.clearbutton.IdleBorderThickness = 1;
            this.clearbutton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.clearbutton.IdleIconLeftImage = null;
            this.clearbutton.IdleIconRightImage = null;
            this.clearbutton.IndicateFocus = false;
            this.clearbutton.Location = new System.Drawing.Point(579, 36);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.clearbutton.OnDisabledState.BorderRadius = 1;
            this.clearbutton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.clearbutton.OnDisabledState.BorderThickness = 1;
            this.clearbutton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.clearbutton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.clearbutton.OnDisabledState.IconLeftImage = null;
            this.clearbutton.OnDisabledState.IconRightImage = null;
            this.clearbutton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.clearbutton.onHoverState.BorderRadius = 1;
            this.clearbutton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.clearbutton.onHoverState.BorderThickness = 1;
            this.clearbutton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.clearbutton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.clearbutton.onHoverState.IconLeftImage = null;
            this.clearbutton.onHoverState.IconRightImage = null;
            this.clearbutton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.clearbutton.OnIdleState.BorderRadius = 1;
            this.clearbutton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.clearbutton.OnIdleState.BorderThickness = 1;
            this.clearbutton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.clearbutton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.clearbutton.OnIdleState.IconLeftImage = null;
            this.clearbutton.OnIdleState.IconRightImage = null;
            this.clearbutton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.clearbutton.OnPressedState.BorderRadius = 1;
            this.clearbutton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.clearbutton.OnPressedState.BorderThickness = 1;
            this.clearbutton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.clearbutton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.clearbutton.OnPressedState.IconLeftImage = null;
            this.clearbutton.OnPressedState.IconRightImage = null;
            this.clearbutton.Size = new System.Drawing.Size(169, 49);
            this.clearbutton.TabIndex = 7;
            this.clearbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clearbutton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.clearbutton.TextMarginLeft = 0;
            this.clearbutton.TextPadding = new System.Windows.Forms.Padding(0);
            this.clearbutton.UseDefaultRadiusAndThickness = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // passwordtool
            // 
            this.passwordtool.Controls.Add(this.copybutpass);
            this.passwordtool.Controls.Add(this.buttonclear);
            this.passwordtool.Controls.Add(this.textBoxpass);
            this.passwordtool.Controls.Add(this.createpass);
            this.passwordtool.Controls.Add(this.numericupdownpass);
            this.passwordtool.Controls.Add(this.lengthpass);
            this.passwordtool.Controls.Add(this.checkedListpass);
            this.passwordtool.Location = new System.Drawing.Point(4, 25);
            this.passwordtool.Name = "passwordtool";
            this.passwordtool.Size = new System.Drawing.Size(792, 393);
            this.passwordtool.TabIndex = 3;
            this.passwordtool.Text = "Пароли";
            this.passwordtool.UseVisualStyleBackColor = true;
            // 
            // checkedListpass
            // 
            this.checkedListpass.CheckOnClick = true;
            this.checkedListpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListpass.FormattingEnabled = true;
            this.checkedListpass.Items.AddRange(new object[] {
            "Цифры",
            "Прописные буквы",
            "Заглавные буквы",
            "Специальные символы ( !, @, #, $, %, *, &, ?, №)"});
            this.checkedListpass.Location = new System.Drawing.Point(22, 16);
            this.checkedListpass.Name = "checkedListpass";
            this.checkedListpass.Size = new System.Drawing.Size(473, 180);
            this.checkedListpass.TabIndex = 2;
            // 
            // lengthpass
            // 
            this.lengthpass.AutoSize = true;
            this.lengthpass.Location = new System.Drawing.Point(572, 27);
            this.lengthpass.Name = "lengthpass";
            this.lengthpass.Size = new System.Drawing.Size(103, 17);
            this.lengthpass.TabIndex = 3;
            this.lengthpass.Text = "Длина пароля";
            // 
            // numericupdownpass
            // 
            this.numericupdownpass.Location = new System.Drawing.Point(557, 66);
            this.numericupdownpass.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericupdownpass.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericupdownpass.Name = "numericupdownpass";
            this.numericupdownpass.Size = new System.Drawing.Size(147, 22);
            this.numericupdownpass.TabIndex = 4;
            this.numericupdownpass.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // createpass
            // 
            this.createpass.Location = new System.Drawing.Point(202, 264);
            this.createpass.Name = "createpass";
            this.createpass.Size = new System.Drawing.Size(162, 81);
            this.createpass.TabIndex = 5;
            this.createpass.Text = "Создать пароль";
            this.createpass.UseVisualStyleBackColor = true;
            this.createpass.Click += new System.EventHandler(this.createpass_Click);
            // 
            // textBoxpass
            // 
            this.textBoxpass.Location = new System.Drawing.Point(22, 220);
            this.textBoxpass.Name = "textBoxpass";
            this.textBoxpass.Size = new System.Drawing.Size(525, 22);
            this.textBoxpass.TabIndex = 6;
            // 
            // buttonclear
            // 
            this.buttonclear.Location = new System.Drawing.Point(600, 201);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(133, 50);
            this.buttonclear.TabIndex = 7;
            this.buttonclear.Text = "Очистить";
            this.buttonclear.UseVisualStyleBackColor = true;
            this.buttonclear.Click += new System.EventHandler(this.buttonclear_Click);
            // 
            // copybutpass
            // 
            this.copybutpass.Location = new System.Drawing.Point(600, 279);
            this.copybutpass.Name = "copybutpass";
            this.copybutpass.Size = new System.Drawing.Size(133, 51);
            this.copybutpass.TabIndex = 8;
            this.copybutpass.Text = "Копировать";
            this.copybutpass.UseVisualStyleBackColor = true;
            this.copybutpass.Click += new System.EventHandler(this.copybutpass_Click);
            // 
            // scoretool
            // 
            this.scoretool.Controls.Add(this.passwordtool);
            this.scoretool.Controls.Add(this.generator);
            this.scoretool.Controls.Add(this.counter);
            this.scoretool.Controls.Add(this.notepad);
            this.scoretool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoretool.Location = new System.Drawing.Point(0, 28);
            this.scoretool.Name = "scoretool";
            this.scoretool.SelectedIndex = 0;
            this.scoretool.Size = new System.Drawing.Size(800, 422);
            this.scoretool.TabIndex = 1;
            // 
            // scorecount
            // 
            this.scorecount.AllowParentOverrides = false;
            this.scorecount.AutoEllipsis = false;
            this.scorecount.Cursor = System.Windows.Forms.Cursors.Default;
            this.scorecount.CursorType = System.Windows.Forms.Cursors.Default;
            this.scorecount.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorecount.Location = new System.Drawing.Point(260, 170);
            this.scorecount.Name = "scorecount";
            this.scorecount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.scorecount.Size = new System.Drawing.Size(12, 27);
            this.scorecount.TabIndex = 4;
            this.scorecount.Text = "0";
            this.scorecount.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.scorecount.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // подробнееОбУтилитахToolStripMenuItem
            // 
            this.подробнееОбУтилитахToolStripMenuItem.Name = "подробнееОбУтилитахToolStripMenuItem";
            this.подробнееОбУтилитахToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.подробнееОбУтилитахToolStripMenuItem.Text = "Подробнее об утилитах";
            this.подробнееОбУтилитахToolStripMenuItem.Click += new System.EventHandler(this.подробнееОбУтилитахToolStripMenuItem_Click);
            // 
            // подробнееОИгреToolStripMenuItem
            // 
            this.подробнееОИгреToolStripMenuItem.Name = "подробнееОИгреToolStripMenuItem";
            this.подробнееОИгреToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.подробнееОИгреToolStripMenuItem.Text = "Подробнее о игре";
            this.подробнееОИгреToolStripMenuItem.Click += new System.EventHandler(this.подробнееОИгреToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scoretool);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Мои утилиты";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.notepad.ResumeLayout(false);
            this.counter.ResumeLayout(false);
            this.counter.PerformLayout();
            this.generator.ResumeLayout(false);
            this.generator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minvaluegen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxvaluegen)).EndInit();
            this.passwordtool.ResumeLayout(false);
            this.passwordtool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericupdownpass)).EndInit();
            this.scoretool.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton pluscount;
        private System.Windows.Forms.ToolStripMenuItem notepadclear;
        private System.Windows.Forms.ToolStripMenuItem adddate;
        private System.Windows.Forms.ToolStripMenuItem addtime;
        private System.Windows.Forms.ToolStripMenuItem addscoreandtime;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem notepadsave;
        private System.Windows.Forms.ToolStripMenuItem notepadload;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запуститьИгруToolStripMenuItem;
        private System.Windows.Forms.TabPage notepad;
        private System.Windows.Forms.RichTextBox notepadwrite;
        private System.Windows.Forms.TabPage counter;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton plusscount;
        private Bunifu.UI.WinForms.BunifuLabel scorecount;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton resetcount;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton minuscount;
        private System.Windows.Forms.TabPage generator;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton clearbutton;
        private System.Windows.Forms.TextBox Textboxrandm;
        private System.Windows.Forms.NumericUpDown maxvaluegen;
        private System.Windows.Forms.NumericUpDown minvaluegen;
        private System.Windows.Forms.Label maxgenerator;
        private System.Windows.Forms.Label mingenerator;
        private System.Windows.Forms.Label scoregenerator;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton startgenerator;
        private System.Windows.Forms.TabPage passwordtool;
        private System.Windows.Forms.Button copybutpass;
        private System.Windows.Forms.Button buttonclear;
        private System.Windows.Forms.TextBox textBoxpass;
        private System.Windows.Forms.Button createpass;
        private System.Windows.Forms.NumericUpDown numericupdownpass;
        private System.Windows.Forms.Label lengthpass;
        private System.Windows.Forms.CheckedListBox checkedListpass;
        private System.Windows.Forms.TabControl scoretool;
        private System.Windows.Forms.ToolStripMenuItem подробнееОбУтилитахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подробнееОИгреToolStripMenuItem;
    }
}

