namespace MyNewCalc
{
    partial class FormCalc
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.typeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.engineeringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelLeft = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnZnak = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnMultiple = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.bетPI = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnInverse = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnSinus = new System.Windows.Forms.Button();
            this.btnXSquare = new System.Windows.Forms.Button();
            this.btnCosinus = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.btnTangens = new System.Windows.Forms.Button();
            this.btnXCube = new System.Windows.Forms.Button();
            this.btnFirstBracket = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.btnBin = new System.Windows.Forms.Button();
            this.btnPersentage = new System.Windows.Forms.Button();
            this.btnSecondBracket = new System.Windows.Forms.Button();
            this.btnHex = new System.Windows.Forms.Button();
            this.btnReserve1 = new System.Windows.Forms.Button();
            this.btnOct = new System.Windows.Forms.Button();
            this.btnReserve2 = new System.Windows.Forms.Button();
            this.btnDec = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.lblShowOper = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.typeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(875, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // typeToolStripMenuItem
            // 
            this.typeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standartToolStripMenuItem,
            this.engineeringToolStripMenuItem});
            this.typeToolStripMenuItem.Name = "typeToolStripMenuItem";
            this.typeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.typeToolStripMenuItem.Text = "Type";
            // 
            // standartToolStripMenuItem
            // 
            this.standartToolStripMenuItem.Name = "standartToolStripMenuItem";
            this.standartToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.standartToolStripMenuItem.Text = "Standart";
            this.standartToolStripMenuItem.Click += new System.EventHandler(this.StandartToolStripMenuItem_Click);
            // 
            // engineeringToolStripMenuItem
            // 
            this.engineeringToolStripMenuItem.Name = "engineeringToolStripMenuItem";
            this.engineeringToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.engineeringToolStripMenuItem.Text = "Engineering";
            this.engineeringToolStripMenuItem.Click += new System.EventHandler(this.EngineeringToolStripMenuItem_Click);
            // 
            // btnDelLeft
            // 
            this.btnDelLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelLeft.Location = new System.Drawing.Point(13, 80);
            this.btnDelLeft.Name = "btnDelLeft";
            this.btnDelLeft.Size = new System.Drawing.Size(67, 63);
            this.btnDelLeft.TabIndex = 1;
            this.btnDelLeft.Text = "←x";
            this.btnDelLeft.UseVisualStyleBackColor = true;
            this.btnDelLeft.Click += new System.EventHandler(this.BtnDelLeft_Click);
            // 
            // btnCE
            // 
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCE.Location = new System.Drawing.Point(86, 80);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(67, 63);
            this.btnCE.TabIndex = 1;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.BtnCE_Click);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnC.Location = new System.Drawing.Point(159, 80);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(67, 63);
            this.btnC.TabIndex = 1;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // btnZnak
            // 
            this.btnZnak.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnZnak.Location = new System.Drawing.Point(232, 80);
            this.btnZnak.Name = "btnZnak";
            this.btnZnak.Size = new System.Drawing.Size(67, 63);
            this.btnZnak.TabIndex = 1;
            this.btnZnak.Text = "±";
            this.btnZnak.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(13, 149);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 63);
            this.button4.TabIndex = 1;
            this.button4.Tag = "7";
            this.button4.Text = "7";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn8.Location = new System.Drawing.Point(86, 149);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(67, 63);
            this.btn8.TabIndex = 1;
            this.btn8.Tag = "8";
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn9.Location = new System.Drawing.Point(159, 149);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(67, 63);
            this.btn9.TabIndex = 1;
            this.btn9.Tag = "9";
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlus.Location = new System.Drawing.Point(232, 149);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(67, 63);
            this.btnPlus.TabIndex = 1;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.Arithmetic_Operator);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn4.Location = new System.Drawing.Point(13, 218);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(67, 63);
            this.btn4.TabIndex = 1;
            this.btn4.Tag = "4";
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn5.Location = new System.Drawing.Point(86, 218);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(67, 63);
            this.btn5.TabIndex = 1;
            this.btn5.Tag = "5";
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn6.Location = new System.Drawing.Point(159, 218);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(67, 63);
            this.btn6.TabIndex = 1;
            this.btn6.Tag = "6";
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinus.Location = new System.Drawing.Point(232, 218);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(67, 63);
            this.btnMinus.TabIndex = 1;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.Arithmetic_Operator);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn1.Location = new System.Drawing.Point(13, 287);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(67, 63);
            this.btn1.TabIndex = 1;
            this.btn1.Tag = "1";
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn2.Location = new System.Drawing.Point(86, 287);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(67, 63);
            this.btn2.TabIndex = 1;
            this.btn2.Tag = "2";
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn3.Location = new System.Drawing.Point(159, 287);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(67, 63);
            this.btn3.TabIndex = 1;
            this.btn3.Tag = "3";
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnMultiple
            // 
            this.btnMultiple.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMultiple.Location = new System.Drawing.Point(232, 287);
            this.btnMultiple.Name = "btnMultiple";
            this.btnMultiple.Size = new System.Drawing.Size(67, 63);
            this.btnMultiple.TabIndex = 1;
            this.btnMultiple.Text = "*";
            this.btnMultiple.UseVisualStyleBackColor = true;
            this.btnMultiple.Click += new System.EventHandler(this.Arithmetic_Operator);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn0.Location = new System.Drawing.Point(13, 356);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(67, 63);
            this.btn0.TabIndex = 1;
            this.btn0.Tag = "0";
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPoint.Location = new System.Drawing.Point(86, 356);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(67, 63);
            this.btnPoint.TabIndex = 1;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnResult
            // 
            this.btnResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnResult.Location = new System.Drawing.Point(159, 356);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(67, 63);
            this.btnResult.TabIndex = 1;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.BtnResult_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDivide.Location = new System.Drawing.Point(232, 356);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(67, 63);
            this.btnDivide.TabIndex = 1;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.Arithmetic_Operator);
            // 
            // bетPI
            // 
            this.bетPI.Font = new System.Drawing.Font("Consolas", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bетPI.Location = new System.Drawing.Point(468, 82);
            this.bетPI.Name = "bетPI";
            this.bетPI.Size = new System.Drawing.Size(67, 63);
            this.bетPI.TabIndex = 1;
            this.bетPI.Text = "π";
            this.toolTip1.SetToolTip(this.bетPI, "number Math PI");
            this.bетPI.UseVisualStyleBackColor = true;
            this.bетPI.Click += new System.EventHandler(this.BетPI_Click);
            // 
            // btnLog
            // 
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLog.Location = new System.Drawing.Point(395, 287);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(67, 63);
            this.btnLog.TabIndex = 1;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.BtnLog_Click);
            // 
            // btnInverse
            // 
            this.btnInverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInverse.Location = new System.Drawing.Point(468, 151);
            this.btnInverse.Name = "btnInverse";
            this.btnInverse.Size = new System.Drawing.Size(67, 63);
            this.btnInverse.TabIndex = 1;
            this.btnInverse.Text = "1/x";
            this.btnInverse.UseVisualStyleBackColor = true;
            this.btnInverse.Click += new System.EventHandler(this.BtnInverse_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSqrt.Location = new System.Drawing.Point(395, 81);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(67, 63);
            this.btnSqrt.TabIndex = 1;
            this.btnSqrt.Text = "√";
            this.toolTip1.SetToolTip(this.btnSqrt, "Корень степени а из х");
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.BtnSqrt_Click);
            // 
            // btnSinus
            // 
            this.btnSinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSinus.Location = new System.Drawing.Point(468, 220);
            this.btnSinus.Name = "btnSinus";
            this.btnSinus.Size = new System.Drawing.Size(67, 63);
            this.btnSinus.TabIndex = 1;
            this.btnSinus.Text = "Sin";
            this.btnSinus.UseVisualStyleBackColor = true;
            this.btnSinus.Click += new System.EventHandler(this.BtnSinus_Click);
            // 
            // btnXSquare
            // 
            this.btnXSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnXSquare.Location = new System.Drawing.Point(395, 149);
            this.btnXSquare.Name = "btnXSquare";
            this.btnXSquare.Size = new System.Drawing.Size(67, 63);
            this.btnXSquare.TabIndex = 1;
            this.btnXSquare.Text = "x²";
            this.btnXSquare.UseVisualStyleBackColor = true;
            this.btnXSquare.Click += new System.EventHandler(this.BtnXSquare_Click);
            // 
            // btnCosinus
            // 
            this.btnCosinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCosinus.Location = new System.Drawing.Point(468, 289);
            this.btnCosinus.Name = "btnCosinus";
            this.btnCosinus.Size = new System.Drawing.Size(67, 63);
            this.btnCosinus.TabIndex = 1;
            this.btnCosinus.Text = "Cos";
            this.btnCosinus.UseVisualStyleBackColor = true;
            this.btnCosinus.Click += new System.EventHandler(this.BtnCosinus_Click);
            // 
            // button27
            // 
            this.button27.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button27.Location = new System.Drawing.Point(541, 83);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(67, 63);
            this.button27.TabIndex = 1;
            this.button27.Text = "S";
            this.button27.UseVisualStyleBackColor = true;
            // 
            // btnTangens
            // 
            this.btnTangens.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTangens.Location = new System.Drawing.Point(468, 358);
            this.btnTangens.Name = "btnTangens";
            this.btnTangens.Size = new System.Drawing.Size(67, 63);
            this.btnTangens.TabIndex = 1;
            this.btnTangens.Text = "Tan";
            this.btnTangens.UseVisualStyleBackColor = true;
            this.btnTangens.Click += new System.EventHandler(this.BtnTangens_Click);
            // 
            // btnXCube
            // 
            this.btnXCube.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnXCube.Location = new System.Drawing.Point(395, 219);
            this.btnXCube.Name = "btnXCube";
            this.btnXCube.Size = new System.Drawing.Size(67, 63);
            this.btnXCube.TabIndex = 1;
            this.btnXCube.Text = "x3";
            this.btnXCube.UseVisualStyleBackColor = true;
            this.btnXCube.Click += new System.EventHandler(this.BtnXCube_Click);
            // 
            // btnFirstBracket
            // 
            this.btnFirstBracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFirstBracket.Location = new System.Drawing.Point(322, 80);
            this.btnFirstBracket.Name = "btnFirstBracket";
            this.btnFirstBracket.Size = new System.Drawing.Size(67, 63);
            this.btnFirstBracket.TabIndex = 1;
            this.btnFirstBracket.Text = "(";
            this.btnFirstBracket.UseVisualStyleBackColor = true;
            // 
            // button31
            // 
            this.button31.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button31.Location = new System.Drawing.Point(395, 357);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(67, 63);
            this.button31.TabIndex = 1;
            this.button31.Text = "Ln ";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.Button31_Click);
            // 
            // btnBin
            // 
            this.btnBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBin.Location = new System.Drawing.Point(541, 152);
            this.btnBin.Name = "btnBin";
            this.btnBin.Size = new System.Drawing.Size(67, 63);
            this.btnBin.TabIndex = 1;
            this.btnBin.Text = "Bin";
            this.btnBin.UseVisualStyleBackColor = true;
            this.btnBin.Click += new System.EventHandler(this.BtnBin_Click);
            // 
            // btnPersentage
            // 
            this.btnPersentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPersentage.Location = new System.Drawing.Point(322, 356);
            this.btnPersentage.Name = "btnPersentage";
            this.btnPersentage.Size = new System.Drawing.Size(67, 63);
            this.btnPersentage.TabIndex = 1;
            this.btnPersentage.Text = "%";
            this.btnPersentage.UseVisualStyleBackColor = true;
            this.btnPersentage.Click += new System.EventHandler(this.BtnPersentage_Click);
            // 
            // btnSecondBracket
            // 
            this.btnSecondBracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSecondBracket.Location = new System.Drawing.Point(322, 150);
            this.btnSecondBracket.Name = "btnSecondBracket";
            this.btnSecondBracket.Size = new System.Drawing.Size(67, 63);
            this.btnSecondBracket.TabIndex = 1;
            this.btnSecondBracket.Text = ")";
            this.btnSecondBracket.UseVisualStyleBackColor = true;
            // 
            // btnHex
            // 
            this.btnHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHex.Location = new System.Drawing.Point(541, 221);
            this.btnHex.Name = "btnHex";
            this.btnHex.Size = new System.Drawing.Size(67, 63);
            this.btnHex.TabIndex = 1;
            this.btnHex.Text = "Hex";
            this.btnHex.UseVisualStyleBackColor = true;
            this.btnHex.Click += new System.EventHandler(this.BtnHex_Click);
            // 
            // btnReserve1
            // 
            this.btnReserve1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReserve1.Location = new System.Drawing.Point(322, 288);
            this.btnReserve1.Name = "btnReserve1";
            this.btnReserve1.Size = new System.Drawing.Size(67, 63);
            this.btnReserve1.TabIndex = 1;
            this.btnReserve1.Text = "x^y";
            this.btnReserve1.UseVisualStyleBackColor = true;
            // 
            // btnOct
            // 
            this.btnOct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOct.Location = new System.Drawing.Point(541, 290);
            this.btnOct.Name = "btnOct";
            this.btnOct.Size = new System.Drawing.Size(67, 63);
            this.btnOct.TabIndex = 1;
            this.btnOct.Text = "Oct";
            this.btnOct.UseVisualStyleBackColor = true;
            this.btnOct.Click += new System.EventHandler(this.BtnOct_Click);
            // 
            // btnReserve2
            // 
            this.btnReserve2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReserve2.Location = new System.Drawing.Point(322, 219);
            this.btnReserve2.Name = "btnReserve2";
            this.btnReserve2.Size = new System.Drawing.Size(67, 63);
            this.btnReserve2.TabIndex = 1;
            this.btnReserve2.Text = "^";
            this.btnReserve2.UseVisualStyleBackColor = true;
            // 
            // btnDec
            // 
            this.btnDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDec.Location = new System.Drawing.Point(541, 359);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(67, 63);
            this.btnDec.TabIndex = 1;
            this.btnDec.Text = "Dec";
            this.btnDec.UseVisualStyleBackColor = true;
            this.btnDec.Click += new System.EventHandler(this.BtnDec_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDisplay.Location = new System.Drawing.Point(13, 29);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(286, 45);
            this.txtDisplay.TabIndex = 2;
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblShowOper
            // 
            this.lblShowOper.AutoSize = true;
            this.lblShowOper.Location = new System.Drawing.Point(16, 32);
            this.lblShowOper.Name = "lblShowOper";
            this.lblShowOper.Size = new System.Drawing.Size(35, 13);
            this.lblShowOper.TabIndex = 3;
            this.lblShowOper.Text = "label1";
            // 
            // FormCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 436);
            this.Controls.Add(this.lblShowOper);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btnDec);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnReserve2);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnOct);
            this.Controls.Add(this.btnMultiple);
            this.Controls.Add(this.btnReserve1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnHex);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnSecondBracket);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btnPersentage);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.btnBin);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnFirstBracket);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnXCube);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btnTangens);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.btnZnak);
            this.Controls.Add(this.btnCosinus);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnXSquare);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btnSinus);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnInverse);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.bетPI);
            this.Controls.Add(this.btnDelLeft);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(67, 63);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.FormCalc_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NumKeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem typeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem engineeringToolStripMenuItem;
        private System.Windows.Forms.Button btnDelLeft;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnZnak;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnMultiple;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button bетPI;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnInverse;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnSinus;
        private System.Windows.Forms.Button btnXSquare;
        private System.Windows.Forms.Button btnCosinus;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button btnTangens;
        private System.Windows.Forms.Button btnXCube;
        private System.Windows.Forms.Button btnFirstBracket;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button btnBin;
        private System.Windows.Forms.Button btnPersentage;
        private System.Windows.Forms.Button btnSecondBracket;
        private System.Windows.Forms.Button btnHex;
        private System.Windows.Forms.Button btnReserve1;
        private System.Windows.Forms.Button btnOct;
        private System.Windows.Forms.Button btnReserve2;
        private System.Windows.Forms.Button btnDec;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Label lblShowOper;
    }
}

