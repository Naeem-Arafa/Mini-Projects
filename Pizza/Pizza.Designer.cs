namespace Pizza
{
    partial class Pizza
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
            this.labmain = new System.Windows.Forms.Label();
            this.groupBoxCrustType = new System.Windows.Forms.GroupBox();
            this.radButThickCrust = new System.Windows.Forms.RadioButton();
            this.radButThinCrust = new System.Windows.Forms.RadioButton();
            this.groupBoxSize = new System.Windows.Forms.GroupBox();
            this.radButLarge = new System.Windows.Forms.RadioButton();
            this.radButMedium = new System.Windows.Forms.RadioButton();
            this.radButSmall = new System.Windows.Forms.RadioButton();
            this.groupBoxToppings = new System.Windows.Forms.GroupBox();
            this.chBoxPeppers = new System.Windows.Forms.CheckBox();
            this.chBoxOnion = new System.Windows.Forms.CheckBox();
            this.chBoxTomatoes = new System.Windows.Forms.CheckBox();
            this.chBoxOlives = new System.Windows.Forms.CheckBox();
            this.chBoxMushrooms = new System.Windows.Forms.CheckBox();
            this.chBoxCheese = new System.Windows.Forms.CheckBox();
            this.groupBoxWhereToEat = new System.Windows.Forms.GroupBox();
            this.radButTakeAway = new System.Windows.Forms.RadioButton();
            this.radButEatIn = new System.Windows.Forms.RadioButton();
            this.groupBoxOrderSumm = new System.Windows.Forms.GroupBox();
            this.labToTotalPrice = new System.Windows.Forms.Label();
            this.labToWhereEat = new System.Windows.Forms.Label();
            this.labToCrust = new System.Windows.Forms.Label();
            this.labToToppings = new System.Windows.Forms.Label();
            this.labToSize = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labWhereToEat = new System.Windows.Forms.Label();
            this.labCrustType = new System.Windows.Forms.Label();
            this.labToppings = new System.Windows.Forms.Label();
            this.labSize = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBoxCrustType.SuspendLayout();
            this.groupBoxSize.SuspendLayout();
            this.groupBoxToppings.SuspendLayout();
            this.groupBoxWhereToEat.SuspendLayout();
            this.groupBoxOrderSumm.SuspendLayout();
            this.SuspendLayout();
            // 
            // labmain
            // 
            this.labmain.AutoSize = true;
            this.labmain.BackColor = System.Drawing.Color.Transparent;
            this.labmain.Font = new System.Drawing.Font("Forte", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labmain.ForeColor = System.Drawing.Color.Orange;
            this.labmain.Location = new System.Drawing.Point(387, 46);
            this.labmain.Name = "labmain";
            this.labmain.Size = new System.Drawing.Size(475, 66);
            this.labmain.TabIndex = 0;
            this.labmain.Text = "Make Your Pizza";
            // 
            // groupBoxCrustType
            // 
            this.groupBoxCrustType.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxCrustType.Controls.Add(this.radButThickCrust);
            this.groupBoxCrustType.Controls.Add(this.radButThinCrust);
            this.groupBoxCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCrustType.ForeColor = System.Drawing.Color.Orange;
            this.groupBoxCrustType.Location = new System.Drawing.Point(30, 123);
            this.groupBoxCrustType.Name = "groupBoxCrustType";
            this.groupBoxCrustType.Size = new System.Drawing.Size(211, 162);
            this.groupBoxCrustType.TabIndex = 1;
            this.groupBoxCrustType.TabStop = false;
            this.groupBoxCrustType.Text = "CRUST TYPE";
            // 
            // radButThickCrust
            // 
            this.radButThickCrust.AutoSize = true;
            this.radButThickCrust.BackColor = System.Drawing.Color.Transparent;
            this.radButThickCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButThickCrust.Location = new System.Drawing.Point(34, 105);
            this.radButThickCrust.Name = "radButThickCrust";
            this.radButThickCrust.Size = new System.Drawing.Size(134, 26);
            this.radButThickCrust.TabIndex = 1;
            this.radButThickCrust.TabStop = true;
            this.radButThickCrust.Tag = "10";
            this.radButThickCrust.Text = "Thick Crust";
            this.radButThickCrust.UseVisualStyleBackColor = false;
            this.radButThickCrust.CheckedChanged += new System.EventHandler(this.UpdateCrust);
            // 
            // radButThinCrust
            // 
            this.radButThinCrust.AutoSize = true;
            this.radButThinCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButThinCrust.Location = new System.Drawing.Point(34, 55);
            this.radButThinCrust.Name = "radButThinCrust";
            this.radButThinCrust.Size = new System.Drawing.Size(125, 26);
            this.radButThinCrust.TabIndex = 0;
            this.radButThinCrust.TabStop = true;
            this.radButThinCrust.Tag = "0";
            this.radButThinCrust.Text = "Thin Crust";
            this.radButThinCrust.UseVisualStyleBackColor = true;
            this.radButThinCrust.CheckedChanged += new System.EventHandler(this.UpdateCrust);
            // 
            // groupBoxSize
            // 
            this.groupBoxSize.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxSize.Controls.Add(this.radButLarge);
            this.groupBoxSize.Controls.Add(this.radButMedium);
            this.groupBoxSize.Controls.Add(this.radButSmall);
            this.groupBoxSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSize.ForeColor = System.Drawing.Color.Orange;
            this.groupBoxSize.Location = new System.Drawing.Point(277, 123);
            this.groupBoxSize.Name = "groupBoxSize";
            this.groupBoxSize.Size = new System.Drawing.Size(185, 208);
            this.groupBoxSize.TabIndex = 2;
            this.groupBoxSize.TabStop = false;
            this.groupBoxSize.Text = "SIZE";
            // 
            // radButLarge
            // 
            this.radButLarge.AutoSize = true;
            this.radButLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButLarge.ForeColor = System.Drawing.Color.Orange;
            this.radButLarge.Location = new System.Drawing.Point(41, 155);
            this.radButLarge.Name = "radButLarge";
            this.radButLarge.Size = new System.Drawing.Size(82, 26);
            this.radButLarge.TabIndex = 4;
            this.radButLarge.TabStop = true;
            this.radButLarge.Tag = "50";
            this.radButLarge.Text = "Large";
            this.radButLarge.UseVisualStyleBackColor = true;
            this.radButLarge.CheckedChanged += new System.EventHandler(this.UpdateSize);
            // 
            // radButMedium
            // 
            this.radButMedium.AutoSize = true;
            this.radButMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButMedium.ForeColor = System.Drawing.Color.Orange;
            this.radButMedium.Location = new System.Drawing.Point(41, 105);
            this.radButMedium.Name = "radButMedium";
            this.radButMedium.Size = new System.Drawing.Size(99, 26);
            this.radButMedium.TabIndex = 3;
            this.radButMedium.TabStop = true;
            this.radButMedium.Tag = "40";
            this.radButMedium.Text = "Medium";
            this.radButMedium.UseVisualStyleBackColor = true;
            this.radButMedium.CheckedChanged += new System.EventHandler(this.UpdateSize);
            // 
            // radButSmall
            // 
            this.radButSmall.AutoSize = true;
            this.radButSmall.BackColor = System.Drawing.Color.Transparent;
            this.radButSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButSmall.ForeColor = System.Drawing.Color.Orange;
            this.radButSmall.Location = new System.Drawing.Point(41, 55);
            this.radButSmall.Name = "radButSmall";
            this.radButSmall.Size = new System.Drawing.Size(80, 26);
            this.radButSmall.TabIndex = 2;
            this.radButSmall.TabStop = true;
            this.radButSmall.Tag = "30";
            this.radButSmall.Text = "Small";
            this.radButSmall.UseVisualStyleBackColor = false;
            this.radButSmall.CheckedChanged += new System.EventHandler(this.UpdateSize);
            // 
            // groupBoxToppings
            // 
            this.groupBoxToppings.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxToppings.Controls.Add(this.chBoxPeppers);
            this.groupBoxToppings.Controls.Add(this.chBoxOnion);
            this.groupBoxToppings.Controls.Add(this.chBoxTomatoes);
            this.groupBoxToppings.Controls.Add(this.chBoxOlives);
            this.groupBoxToppings.Controls.Add(this.chBoxMushrooms);
            this.groupBoxToppings.Controls.Add(this.chBoxCheese);
            this.groupBoxToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxToppings.ForeColor = System.Drawing.Color.Orange;
            this.groupBoxToppings.Location = new System.Drawing.Point(509, 123);
            this.groupBoxToppings.Name = "groupBoxToppings";
            this.groupBoxToppings.Size = new System.Drawing.Size(372, 208);
            this.groupBoxToppings.TabIndex = 3;
            this.groupBoxToppings.TabStop = false;
            this.groupBoxToppings.Text = "TOPPINGS";
            // 
            // chBoxPeppers
            // 
            this.chBoxPeppers.AutoSize = true;
            this.chBoxPeppers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxPeppers.Location = new System.Drawing.Point(25, 148);
            this.chBoxPeppers.Name = "chBoxPeppers";
            this.chBoxPeppers.Size = new System.Drawing.Size(167, 26);
            this.chBoxPeppers.TabIndex = 7;
            this.chBoxPeppers.Tag = "5";
            this.chBoxPeppers.Text = "Green Peppers";
            this.chBoxPeppers.UseVisualStyleBackColor = true;
            this.chBoxPeppers.CheckedChanged += new System.EventHandler(this.UpdateToppings);
            // 
            // chBoxOnion
            // 
            this.chBoxOnion.AutoSize = true;
            this.chBoxOnion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxOnion.Location = new System.Drawing.Point(215, 48);
            this.chBoxOnion.Name = "chBoxOnion";
            this.chBoxOnion.Size = new System.Drawing.Size(85, 26);
            this.chBoxOnion.TabIndex = 8;
            this.chBoxOnion.Tag = "5";
            this.chBoxOnion.Text = "Onion";
            this.chBoxOnion.UseVisualStyleBackColor = true;
            this.chBoxOnion.CheckedChanged += new System.EventHandler(this.UpdateToppings);
            // 
            // chBoxTomatoes
            // 
            this.chBoxTomatoes.AutoSize = true;
            this.chBoxTomatoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxTomatoes.Location = new System.Drawing.Point(215, 148);
            this.chBoxTomatoes.Name = "chBoxTomatoes";
            this.chBoxTomatoes.Size = new System.Drawing.Size(120, 26);
            this.chBoxTomatoes.TabIndex = 10;
            this.chBoxTomatoes.Tag = "5";
            this.chBoxTomatoes.Text = "Tomatoes";
            this.chBoxTomatoes.UseVisualStyleBackColor = true;
            this.chBoxTomatoes.CheckedChanged += new System.EventHandler(this.UpdateToppings);
            // 
            // chBoxOlives
            // 
            this.chBoxOlives.AutoSize = true;
            this.chBoxOlives.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxOlives.Location = new System.Drawing.Point(215, 98);
            this.chBoxOlives.Name = "chBoxOlives";
            this.chBoxOlives.Size = new System.Drawing.Size(88, 26);
            this.chBoxOlives.TabIndex = 9;
            this.chBoxOlives.Tag = "5";
            this.chBoxOlives.Text = "Olives";
            this.chBoxOlives.UseVisualStyleBackColor = true;
            this.chBoxOlives.CheckedChanged += new System.EventHandler(this.UpdateToppings);
            // 
            // chBoxMushrooms
            // 
            this.chBoxMushrooms.AutoSize = true;
            this.chBoxMushrooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxMushrooms.Location = new System.Drawing.Point(25, 98);
            this.chBoxMushrooms.Name = "chBoxMushrooms";
            this.chBoxMushrooms.Size = new System.Drawing.Size(133, 26);
            this.chBoxMushrooms.TabIndex = 6;
            this.chBoxMushrooms.Tag = "5";
            this.chBoxMushrooms.Text = "Mushrooms";
            this.chBoxMushrooms.UseVisualStyleBackColor = true;
            this.chBoxMushrooms.CheckedChanged += new System.EventHandler(this.UpdateToppings);
            // 
            // chBoxCheese
            // 
            this.chBoxCheese.AutoSize = true;
            this.chBoxCheese.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxCheese.Location = new System.Drawing.Point(25, 48);
            this.chBoxCheese.Name = "chBoxCheese";
            this.chBoxCheese.Size = new System.Drawing.Size(153, 26);
            this.chBoxCheese.TabIndex = 5;
            this.chBoxCheese.Tag = "5";
            this.chBoxCheese.Text = "Extra Cheese";
            this.chBoxCheese.UseVisualStyleBackColor = true;
            this.chBoxCheese.CheckedChanged += new System.EventHandler(this.UpdateToppings);
            // 
            // groupBoxWhereToEat
            // 
            this.groupBoxWhereToEat.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxWhereToEat.Controls.Add(this.radButTakeAway);
            this.groupBoxWhereToEat.Controls.Add(this.radButEatIn);
            this.groupBoxWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxWhereToEat.ForeColor = System.Drawing.Color.Orange;
            this.groupBoxWhereToEat.Location = new System.Drawing.Point(509, 378);
            this.groupBoxWhereToEat.Name = "groupBoxWhereToEat";
            this.groupBoxWhereToEat.Size = new System.Drawing.Size(324, 97);
            this.groupBoxWhereToEat.TabIndex = 4;
            this.groupBoxWhereToEat.TabStop = false;
            this.groupBoxWhereToEat.Text = "WHERE TO SET";
            // 
            // radButTakeAway
            // 
            this.radButTakeAway.AutoSize = true;
            this.radButTakeAway.BackColor = System.Drawing.Color.Transparent;
            this.radButTakeAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButTakeAway.Location = new System.Drawing.Point(169, 42);
            this.radButTakeAway.Name = "radButTakeAway";
            this.radButTakeAway.Size = new System.Drawing.Size(128, 26);
            this.radButTakeAway.TabIndex = 12;
            this.radButTakeAway.TabStop = true;
            this.radButTakeAway.Text = "Take away";
            this.radButTakeAway.UseVisualStyleBackColor = false;
            this.radButTakeAway.CheckedChanged += new System.EventHandler(this.UpdateWhereToEat);
            // 
            // radButEatIn
            // 
            this.radButEatIn.AutoSize = true;
            this.radButEatIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButEatIn.Location = new System.Drawing.Point(30, 42);
            this.radButEatIn.Name = "radButEatIn";
            this.radButEatIn.Size = new System.Drawing.Size(83, 26);
            this.radButEatIn.TabIndex = 11;
            this.radButEatIn.TabStop = true;
            this.radButEatIn.Text = "Eat in";
            this.radButEatIn.UseVisualStyleBackColor = true;
            this.radButEatIn.CheckedChanged += new System.EventHandler(this.UpdateWhereToEat);
            // 
            // groupBoxOrderSumm
            // 
            this.groupBoxOrderSumm.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxOrderSumm.Controls.Add(this.labToTotalPrice);
            this.groupBoxOrderSumm.Controls.Add(this.labToWhereEat);
            this.groupBoxOrderSumm.Controls.Add(this.labToCrust);
            this.groupBoxOrderSumm.Controls.Add(this.labToToppings);
            this.groupBoxOrderSumm.Controls.Add(this.labToSize);
            this.groupBoxOrderSumm.Controls.Add(this.label6);
            this.groupBoxOrderSumm.Controls.Add(this.labWhereToEat);
            this.groupBoxOrderSumm.Controls.Add(this.labCrustType);
            this.groupBoxOrderSumm.Controls.Add(this.labToppings);
            this.groupBoxOrderSumm.Controls.Add(this.labSize);
            this.groupBoxOrderSumm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOrderSumm.ForeColor = System.Drawing.Color.Orange;
            this.groupBoxOrderSumm.Location = new System.Drawing.Point(913, 123);
            this.groupBoxOrderSumm.Name = "groupBoxOrderSumm";
            this.groupBoxOrderSumm.Size = new System.Drawing.Size(326, 375);
            this.groupBoxOrderSumm.TabIndex = 5;
            this.groupBoxOrderSumm.TabStop = false;
            this.groupBoxOrderSumm.Text = "ORDER SUMMARY";
            // 
            // labToTotalPrice
            // 
            this.labToTotalPrice.AutoSize = true;
            this.labToTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labToTotalPrice.ForeColor = System.Drawing.Color.White;
            this.labToTotalPrice.Location = new System.Drawing.Point(196, 311);
            this.labToTotalPrice.Name = "labToTotalPrice";
            this.labToTotalPrice.Size = new System.Drawing.Size(0, 22);
            this.labToTotalPrice.TabIndex = 9;
            // 
            // labToWhereEat
            // 
            this.labToWhereEat.AutoSize = true;
            this.labToWhereEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labToWhereEat.ForeColor = System.Drawing.Color.White;
            this.labToWhereEat.Location = new System.Drawing.Point(202, 256);
            this.labToWhereEat.Name = "labToWhereEat";
            this.labToWhereEat.Size = new System.Drawing.Size(0, 22);
            this.labToWhereEat.TabIndex = 8;
            // 
            // labToCrust
            // 
            this.labToCrust.AutoSize = true;
            this.labToCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labToCrust.ForeColor = System.Drawing.Color.White;
            this.labToCrust.Location = new System.Drawing.Point(202, 203);
            this.labToCrust.Name = "labToCrust";
            this.labToCrust.Size = new System.Drawing.Size(0, 22);
            this.labToCrust.TabIndex = 7;
            // 
            // labToToppings
            // 
            this.labToToppings.AutoSize = true;
            this.labToToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labToToppings.ForeColor = System.Drawing.Color.White;
            this.labToToppings.Location = new System.Drawing.Point(56, 126);
            this.labToToppings.MaximumSize = new System.Drawing.Size(300, 1000);
            this.labToToppings.Name = "labToToppings";
            this.labToToppings.Size = new System.Drawing.Size(0, 20);
            this.labToToppings.TabIndex = 6;
            // 
            // labToSize
            // 
            this.labToSize.AutoSize = true;
            this.labToSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labToSize.ForeColor = System.Drawing.Color.White;
            this.labToSize.Location = new System.Drawing.Point(202, 40);
            this.labToSize.Name = "labToSize";
            this.labToSize.Size = new System.Drawing.Size(0, 22);
            this.labToSize.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total Price:";
            // 
            // labWhereToEat
            // 
            this.labWhereToEat.AutoSize = true;
            this.labWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWhereToEat.Location = new System.Drawing.Point(43, 256);
            this.labWhereToEat.Name = "labWhereToEat";
            this.labWhereToEat.Size = new System.Drawing.Size(153, 25);
            this.labWhereToEat.TabIndex = 3;
            this.labWhereToEat.Text = "Where To Eat:";
            // 
            // labCrustType
            // 
            this.labCrustType.AutoSize = true;
            this.labCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCrustType.Location = new System.Drawing.Point(43, 203);
            this.labCrustType.Name = "labCrustType";
            this.labCrustType.Size = new System.Drawing.Size(126, 25);
            this.labCrustType.TabIndex = 2;
            this.labCrustType.Text = "Crust Type:";
            // 
            // labToppings
            // 
            this.labToppings.AutoSize = true;
            this.labToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labToppings.Location = new System.Drawing.Point(43, 90);
            this.labToppings.Name = "labToppings";
            this.labToppings.Size = new System.Drawing.Size(109, 25);
            this.labToppings.TabIndex = 1;
            this.labToppings.Text = "Toppings:";
            // 
            // labSize
            // 
            this.labSize.AutoSize = true;
            this.labSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSize.Location = new System.Drawing.Point(43, 40);
            this.labSize.Name = "labSize";
            this.labSize.Size = new System.Drawing.Size(62, 25);
            this.labSize.TabIndex = 0;
            this.labSize.Text = "Size:";
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Black;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.Orange;
            this.btnOrder.Location = new System.Drawing.Point(651, 565);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(161, 62);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "ORDER";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Black;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Orange;
            this.btnReset.Location = new System.Drawing.Point(931, 565);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(161, 62);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Pizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pizza.Properties.Resources.m0tf456r;
            this.ClientSize = new System.Drawing.Size(1332, 803);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.groupBoxOrderSumm);
            this.Controls.Add(this.groupBoxWhereToEat);
            this.Controls.Add(this.groupBoxToppings);
            this.Controls.Add(this.groupBoxSize);
            this.Controls.Add(this.groupBoxCrustType);
            this.Controls.Add(this.labmain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Pizza";
            this.Text = "Pizza-Menu";
            this.Load += new System.EventHandler(this.Pizza_Load_1);
            this.groupBoxCrustType.ResumeLayout(false);
            this.groupBoxCrustType.PerformLayout();
            this.groupBoxSize.ResumeLayout(false);
            this.groupBoxSize.PerformLayout();
            this.groupBoxToppings.ResumeLayout(false);
            this.groupBoxToppings.PerformLayout();
            this.groupBoxWhereToEat.ResumeLayout(false);
            this.groupBoxWhereToEat.PerformLayout();
            this.groupBoxOrderSumm.ResumeLayout(false);
            this.groupBoxOrderSumm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labmain;
        private System.Windows.Forms.GroupBox groupBoxCrustType;
        private System.Windows.Forms.RadioButton radButThickCrust;
        private System.Windows.Forms.RadioButton radButThinCrust;
        private System.Windows.Forms.GroupBox groupBoxSize;
        private System.Windows.Forms.RadioButton radButLarge;
        private System.Windows.Forms.RadioButton radButMedium;
        private System.Windows.Forms.RadioButton radButSmall;
        private System.Windows.Forms.GroupBox groupBoxToppings;
        private System.Windows.Forms.CheckBox chBoxMushrooms;
        private System.Windows.Forms.CheckBox chBoxCheese;
        private System.Windows.Forms.CheckBox chBoxPeppers;
        private System.Windows.Forms.CheckBox chBoxOnion;
        private System.Windows.Forms.CheckBox chBoxTomatoes;
        private System.Windows.Forms.CheckBox chBoxOlives;
        private System.Windows.Forms.GroupBox groupBoxWhereToEat;
        private System.Windows.Forms.RadioButton radButTakeAway;
        private System.Windows.Forms.RadioButton radButEatIn;
        private System.Windows.Forms.GroupBox groupBoxOrderSumm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labWhereToEat;
        private System.Windows.Forms.Label labCrustType;
        private System.Windows.Forms.Label labToppings;
        private System.Windows.Forms.Label labSize;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label labToSize;
        private System.Windows.Forms.Label labToTotalPrice;
        private System.Windows.Forms.Label labToWhereEat;
        private System.Windows.Forms.Label labToCrust;
        private System.Windows.Forms.Label labToToppings;
    }
}

