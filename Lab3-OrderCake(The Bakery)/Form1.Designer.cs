namespace Lab3_OrderCake_The_Bakery_
{
    partial class frmOrderCake
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
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.grpChoose = new System.Windows.Forms.GroupBox();
            this.grpNumLayers = new System.Windows.Forms.GroupBox();
            this.rad4layers = new System.Windows.Forms.RadioButton();
            this.rad3layers = new System.Windows.Forms.RadioButton();
            this.rad2layers = new System.Windows.Forms.RadioButton();
            this.rad1layer = new System.Windows.Forms.RadioButton();
            this.grpFlavour = new System.Windows.Forms.GroupBox();
            this.radLemonBerry = new System.Windows.Forms.RadioButton();
            this.radBanana = new System.Windows.Forms.RadioButton();
            this.radVanilla = new System.Windows.Forms.RadioButton();
            this.radChocolate = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpCustInfo = new System.Windows.Forms.GroupBox();
            this.grpCustomCake = new System.Windows.Forms.GroupBox();
            this.grpDesign = new System.Windows.Forms.GroupBox();
            this.rad3D = new System.Windows.Forms.RadioButton();
            this.radBow = new System.Windows.Forms.RadioButton();
            this.radEdible = new System.Windows.Forms.RadioButton();
            this.radPolka = new System.Windows.Forms.RadioButton();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.rad12inch = new System.Windows.Forms.RadioButton();
            this.rad10inch = new System.Windows.Forms.RadioButton();
            this.rad8inch = new System.Windows.Forms.RadioButton();
            this.rad6inch = new System.Windows.Forms.RadioButton();
            this.grpOccasion = new System.Windows.Forms.GroupBox();
            this.radWedding = new System.Windows.Forms.RadioButton();
            this.radRetirement = new System.Windows.Forms.RadioButton();
            this.radBirthday = new System.Windows.Forms.RadioButton();
            this.radAnniversary = new System.Windows.Forms.RadioButton();
            this.grpTypeOfCake = new System.Windows.Forms.GroupBox();
            this.radCharacterCake = new System.Windows.Forms.RadioButton();
            this.radCustomCake = new System.Windows.Forms.RadioButton();
            this.lblChooseCharCake = new System.Windows.Forms.Label();
            this.lstCharCake = new System.Windows.Forms.ListBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.grpChoose.SuspendLayout();
            this.grpNumLayers.SuspendLayout();
            this.grpFlavour.SuspendLayout();
            this.grpCustInfo.SuspendLayout();
            this.grpCustomCake.SuspendLayout();
            this.grpDesign.SuspendLayout();
            this.grpSize.SuspendLayout();
            this.grpOccasion.SuspendLayout();
            this.grpTypeOfCake.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(9, 35);
            this.lblFName.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(112, 25);
            this.lblFName.TabIndex = 0;
            this.lblFName.Text = "&First Name:";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(11, 108);
            this.lblLName.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(112, 25);
            this.lblLName.TabIndex = 2;
            this.lblLName.Text = "&Last Name:";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(855, 306);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(135, 44);
            this.btnAddToCart.TabIndex = 10;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(152, 31);
            this.txtFName.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(341, 30);
            this.txtFName.TabIndex = 1;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(152, 100);
            this.txtLName.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(341, 30);
            this.txtLName.TabIndex = 3;
            // 
            // grpChoose
            // 
            this.grpChoose.Controls.Add(this.grpNumLayers);
            this.grpChoose.Controls.Add(this.grpFlavour);
            this.grpChoose.Location = new System.Drawing.Point(615, 45);
            this.grpChoose.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.grpChoose.Name = "grpChoose";
            this.grpChoose.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.grpChoose.Size = new System.Drawing.Size(505, 201);
            this.grpChoose.TabIndex = 13;
            this.grpChoose.TabStop = false;
            this.grpChoose.Text = "Choose";
            // 
            // grpNumLayers
            // 
            this.grpNumLayers.Controls.Add(this.rad4layers);
            this.grpNumLayers.Controls.Add(this.rad3layers);
            this.grpNumLayers.Controls.Add(this.rad2layers);
            this.grpNumLayers.Controls.Add(this.rad1layer);
            this.grpNumLayers.Location = new System.Drawing.Point(282, 35);
            this.grpNumLayers.Margin = new System.Windows.Forms.Padding(4);
            this.grpNumLayers.Name = "grpNumLayers";
            this.grpNumLayers.Padding = new System.Windows.Forms.Padding(4);
            this.grpNumLayers.Size = new System.Drawing.Size(212, 146);
            this.grpNumLayers.TabIndex = 5;
            this.grpNumLayers.TabStop = false;
            this.grpNumLayers.Text = "Number of Layers";
            // 
            // rad4layers
            // 
            this.rad4layers.AutoSize = true;
            this.rad4layers.Location = new System.Drawing.Point(9, 114);
            this.rad4layers.Margin = new System.Windows.Forms.Padding(4);
            this.rad4layers.Name = "rad4layers";
            this.rad4layers.Size = new System.Drawing.Size(108, 29);
            this.rad4layers.TabIndex = 3;
            this.rad4layers.Text = "&4 Layers";
            this.rad4layers.UseVisualStyleBackColor = true;
            // 
            // rad3layers
            // 
            this.rad3layers.AutoSize = true;
            this.rad3layers.Location = new System.Drawing.Point(8, 81);
            this.rad3layers.Margin = new System.Windows.Forms.Padding(4);
            this.rad3layers.Name = "rad3layers";
            this.rad3layers.Size = new System.Drawing.Size(108, 29);
            this.rad3layers.TabIndex = 2;
            this.rad3layers.Text = "&3 Layers";
            this.rad3layers.UseVisualStyleBackColor = true;
            // 
            // rad2layers
            // 
            this.rad2layers.AutoSize = true;
            this.rad2layers.Location = new System.Drawing.Point(8, 52);
            this.rad2layers.Margin = new System.Windows.Forms.Padding(4);
            this.rad2layers.Name = "rad2layers";
            this.rad2layers.Size = new System.Drawing.Size(108, 29);
            this.rad2layers.TabIndex = 1;
            this.rad2layers.Text = "&2 Layers";
            this.rad2layers.UseVisualStyleBackColor = true;
            // 
            // rad1layer
            // 
            this.rad1layer.AutoSize = true;
            this.rad1layer.Checked = true;
            this.rad1layer.Location = new System.Drawing.Point(8, 24);
            this.rad1layer.Margin = new System.Windows.Forms.Padding(4);
            this.rad1layer.Name = "rad1layer";
            this.rad1layer.Size = new System.Drawing.Size(98, 29);
            this.rad1layer.TabIndex = 0;
            this.rad1layer.TabStop = true;
            this.rad1layer.Text = "&1 Layer";
            this.rad1layer.UseVisualStyleBackColor = true;
            // 
            // grpFlavour
            // 
            this.grpFlavour.Controls.Add(this.radLemonBerry);
            this.grpFlavour.Controls.Add(this.radBanana);
            this.grpFlavour.Controls.Add(this.radVanilla);
            this.grpFlavour.Controls.Add(this.radChocolate);
            this.grpFlavour.Location = new System.Drawing.Point(13, 35);
            this.grpFlavour.Margin = new System.Windows.Forms.Padding(4);
            this.grpFlavour.Name = "grpFlavour";
            this.grpFlavour.Padding = new System.Windows.Forms.Padding(4);
            this.grpFlavour.Size = new System.Drawing.Size(219, 146);
            this.grpFlavour.TabIndex = 1;
            this.grpFlavour.TabStop = false;
            this.grpFlavour.Text = "Flavour";
            // 
            // radLemonBerry
            // 
            this.radLemonBerry.AutoSize = true;
            this.radLemonBerry.Location = new System.Drawing.Point(8, 114);
            this.radLemonBerry.Margin = new System.Windows.Forms.Padding(4);
            this.radLemonBerry.Name = "radLemonBerry";
            this.radLemonBerry.Size = new System.Drawing.Size(144, 29);
            this.radLemonBerry.TabIndex = 3;
            this.radLemonBerry.Text = "&Lemon Berry";
            this.radLemonBerry.UseVisualStyleBackColor = true;
            // 
            // radBanana
            // 
            this.radBanana.AutoSize = true;
            this.radBanana.Location = new System.Drawing.Point(8, 81);
            this.radBanana.Margin = new System.Windows.Forms.Padding(4);
            this.radBanana.Name = "radBanana";
            this.radBanana.Size = new System.Drawing.Size(101, 29);
            this.radBanana.TabIndex = 2;
            this.radBanana.Text = "&Banana";
            this.radBanana.UseVisualStyleBackColor = true;
            // 
            // radVanilla
            // 
            this.radVanilla.AutoSize = true;
            this.radVanilla.Location = new System.Drawing.Point(8, 52);
            this.radVanilla.Margin = new System.Windows.Forms.Padding(4);
            this.radVanilla.Name = "radVanilla";
            this.radVanilla.Size = new System.Drawing.Size(92, 29);
            this.radVanilla.TabIndex = 1;
            this.radVanilla.Text = "&Vanilla";
            this.radVanilla.UseVisualStyleBackColor = true;
            // 
            // radChocolate
            // 
            this.radChocolate.AutoSize = true;
            this.radChocolate.Checked = true;
            this.radChocolate.Location = new System.Drawing.Point(8, 24);
            this.radChocolate.Margin = new System.Windows.Forms.Padding(4);
            this.radChocolate.Name = "radChocolate";
            this.radChocolate.Size = new System.Drawing.Size(122, 29);
            this.radChocolate.TabIndex = 0;
            this.radChocolate.TabStop = true;
            this.radChocolate.Text = "&Chocolate";
            this.radChocolate.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(1004, 306);
            this.btnReset.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(135, 44);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1004, 392);
            this.btnExit.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(135, 44);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(17, 11);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(116, 24);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "The Bakery";
            // 
            // grpCustInfo
            // 
            this.grpCustInfo.Controls.Add(this.lblFName);
            this.grpCustInfo.Controls.Add(this.txtFName);
            this.grpCustInfo.Controls.Add(this.lblLName);
            this.grpCustInfo.Controls.Add(this.txtLName);
            this.grpCustInfo.Location = new System.Drawing.Point(21, 45);
            this.grpCustInfo.Margin = new System.Windows.Forms.Padding(4);
            this.grpCustInfo.Name = "grpCustInfo";
            this.grpCustInfo.Padding = new System.Windows.Forms.Padding(4);
            this.grpCustInfo.Size = new System.Drawing.Size(572, 155);
            this.grpCustInfo.TabIndex = 14;
            this.grpCustInfo.TabStop = false;
            this.grpCustInfo.Text = "Customer Information";
            // 
            // grpCustomCake
            // 
            this.grpCustomCake.Controls.Add(this.grpDesign);
            this.grpCustomCake.Controls.Add(this.grpSize);
            this.grpCustomCake.Controls.Add(this.grpOccasion);
            this.grpCustomCake.Location = new System.Drawing.Point(21, 337);
            this.grpCustomCake.Margin = new System.Windows.Forms.Padding(4);
            this.grpCustomCake.Name = "grpCustomCake";
            this.grpCustomCake.Padding = new System.Windows.Forms.Padding(4);
            this.grpCustomCake.Size = new System.Drawing.Size(572, 209);
            this.grpCustomCake.TabIndex = 15;
            this.grpCustomCake.TabStop = false;
            this.grpCustomCake.Text = "Custom Cake";
            // 
            // grpDesign
            // 
            this.grpDesign.Controls.Add(this.rad3D);
            this.grpDesign.Controls.Add(this.radBow);
            this.grpDesign.Controls.Add(this.radEdible);
            this.grpDesign.Controls.Add(this.radPolka);
            this.grpDesign.Location = new System.Drawing.Point(356, 31);
            this.grpDesign.Margin = new System.Windows.Forms.Padding(4);
            this.grpDesign.Name = "grpDesign";
            this.grpDesign.Padding = new System.Windows.Forms.Padding(4);
            this.grpDesign.Size = new System.Drawing.Size(208, 155);
            this.grpDesign.TabIndex = 5;
            this.grpDesign.TabStop = false;
            this.grpDesign.Text = "Design";
            // 
            // rad3D
            // 
            this.rad3D.AutoSize = true;
            this.rad3D.Location = new System.Drawing.Point(8, 114);
            this.rad3D.Margin = new System.Windows.Forms.Padding(4);
            this.rad3D.Name = "rad3D";
            this.rad3D.Size = new System.Drawing.Size(128, 29);
            this.rad3D.TabIndex = 3;
            this.rad3D.Text = "3&D Figures";
            this.rad3D.UseVisualStyleBackColor = true;
            // 
            // radBow
            // 
            this.radBow.AutoSize = true;
            this.radBow.Location = new System.Drawing.Point(8, 81);
            this.radBow.Margin = new System.Windows.Forms.Padding(4);
            this.radBow.Name = "radBow";
            this.radBow.Size = new System.Drawing.Size(148, 29);
            this.radBow.TabIndex = 2;
            this.radBow.Text = "&Fondant Bow";
            this.radBow.UseVisualStyleBackColor = true;
            // 
            // radEdible
            // 
            this.radEdible.AutoSize = true;
            this.radEdible.Location = new System.Drawing.Point(8, 52);
            this.radEdible.Margin = new System.Windows.Forms.Padding(4);
            this.radEdible.Name = "radEdible";
            this.radEdible.Size = new System.Drawing.Size(156, 29);
            this.radEdible.TabIndex = 1;
            this.radEdible.Text = "&Edible Images";
            this.radEdible.UseVisualStyleBackColor = true;
            // 
            // radPolka
            // 
            this.radPolka.AutoSize = true;
            this.radPolka.Checked = true;
            this.radPolka.Location = new System.Drawing.Point(8, 24);
            this.radPolka.Margin = new System.Windows.Forms.Padding(4);
            this.radPolka.Name = "radPolka";
            this.radPolka.Size = new System.Drawing.Size(127, 29);
            this.radPolka.TabIndex = 0;
            this.radPolka.TabStop = true;
            this.radPolka.Text = "&Polka Dots";
            this.radPolka.UseVisualStyleBackColor = true;
            // 
            // grpSize
            // 
            this.grpSize.Controls.Add(this.rad12inch);
            this.grpSize.Controls.Add(this.rad10inch);
            this.grpSize.Controls.Add(this.rad8inch);
            this.grpSize.Controls.Add(this.rad6inch);
            this.grpSize.Location = new System.Drawing.Point(240, 31);
            this.grpSize.Margin = new System.Windows.Forms.Padding(4);
            this.grpSize.Name = "grpSize";
            this.grpSize.Padding = new System.Windows.Forms.Padding(4);
            this.grpSize.Size = new System.Drawing.Size(104, 155);
            this.grpSize.TabIndex = 4;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Size";
            // 
            // rad12inch
            // 
            this.rad12inch.AutoSize = true;
            this.rad12inch.Location = new System.Drawing.Point(8, 114);
            this.rad12inch.Margin = new System.Windows.Forms.Padding(4);
            this.rad12inch.Name = "rad12inch";
            this.rad12inch.Size = new System.Drawing.Size(62, 29);
            this.rad12inch.TabIndex = 3;
            this.rad12inch.Text = "12&\"";
            this.rad12inch.UseVisualStyleBackColor = true;
            // 
            // rad10inch
            // 
            this.rad10inch.AutoSize = true;
            this.rad10inch.Location = new System.Drawing.Point(8, 81);
            this.rad10inch.Margin = new System.Windows.Forms.Padding(4);
            this.rad10inch.Name = "rad10inch";
            this.rad10inch.Size = new System.Drawing.Size(62, 29);
            this.rad10inch.TabIndex = 2;
            this.rad10inch.Text = "1&0\"";
            this.rad10inch.UseVisualStyleBackColor = true;
            // 
            // rad8inch
            // 
            this.rad8inch.AutoSize = true;
            this.rad8inch.Location = new System.Drawing.Point(8, 52);
            this.rad8inch.Margin = new System.Windows.Forms.Padding(4);
            this.rad8inch.Name = "rad8inch";
            this.rad8inch.Size = new System.Drawing.Size(51, 29);
            this.rad8inch.TabIndex = 1;
            this.rad8inch.Text = "&8\"";
            this.rad8inch.UseVisualStyleBackColor = true;
            // 
            // rad6inch
            // 
            this.rad6inch.AutoSize = true;
            this.rad6inch.Checked = true;
            this.rad6inch.Location = new System.Drawing.Point(8, 24);
            this.rad6inch.Margin = new System.Windows.Forms.Padding(4);
            this.rad6inch.Name = "rad6inch";
            this.rad6inch.Size = new System.Drawing.Size(51, 29);
            this.rad6inch.TabIndex = 0;
            this.rad6inch.TabStop = true;
            this.rad6inch.Text = "&6\"";
            this.rad6inch.UseVisualStyleBackColor = true;
            // 
            // grpOccasion
            // 
            this.grpOccasion.Controls.Add(this.radWedding);
            this.grpOccasion.Controls.Add(this.radRetirement);
            this.grpOccasion.Controls.Add(this.radBirthday);
            this.grpOccasion.Controls.Add(this.radAnniversary);
            this.grpOccasion.Location = new System.Drawing.Point(13, 31);
            this.grpOccasion.Margin = new System.Windows.Forms.Padding(4);
            this.grpOccasion.Name = "grpOccasion";
            this.grpOccasion.Padding = new System.Windows.Forms.Padding(4);
            this.grpOccasion.Size = new System.Drawing.Size(219, 155);
            this.grpOccasion.TabIndex = 2;
            this.grpOccasion.TabStop = false;
            this.grpOccasion.Text = "Occasion";
            // 
            // radWedding
            // 
            this.radWedding.AutoSize = true;
            this.radWedding.Location = new System.Drawing.Point(8, 114);
            this.radWedding.Margin = new System.Windows.Forms.Padding(4);
            this.radWedding.Name = "radWedding";
            this.radWedding.Size = new System.Drawing.Size(112, 29);
            this.radWedding.TabIndex = 3;
            this.radWedding.Text = "&Wedding";
            this.radWedding.UseVisualStyleBackColor = true;
            // 
            // radRetirement
            // 
            this.radRetirement.AutoSize = true;
            this.radRetirement.Location = new System.Drawing.Point(8, 81);
            this.radRetirement.Margin = new System.Windows.Forms.Padding(4);
            this.radRetirement.Name = "radRetirement";
            this.radRetirement.Size = new System.Drawing.Size(126, 29);
            this.radRetirement.TabIndex = 2;
            this.radRetirement.Text = "&Retirement";
            this.radRetirement.UseVisualStyleBackColor = true;
            // 
            // radBirthday
            // 
            this.radBirthday.AutoSize = true;
            this.radBirthday.Location = new System.Drawing.Point(8, 52);
            this.radBirthday.Margin = new System.Windows.Forms.Padding(4);
            this.radBirthday.Name = "radBirthday";
            this.radBirthday.Size = new System.Drawing.Size(104, 29);
            this.radBirthday.TabIndex = 1;
            this.radBirthday.Text = "B&irthday";
            this.radBirthday.UseVisualStyleBackColor = true;
            // 
            // radAnniversary
            // 
            this.radAnniversary.AutoSize = true;
            this.radAnniversary.Checked = true;
            this.radAnniversary.Location = new System.Drawing.Point(8, 24);
            this.radAnniversary.Margin = new System.Windows.Forms.Padding(4);
            this.radAnniversary.Name = "radAnniversary";
            this.radAnniversary.Size = new System.Drawing.Size(137, 29);
            this.radAnniversary.TabIndex = 0;
            this.radAnniversary.TabStop = true;
            this.radAnniversary.Text = "&Anniversary";
            this.radAnniversary.UseVisualStyleBackColor = true;
            // 
            // grpTypeOfCake
            // 
            this.grpTypeOfCake.Controls.Add(this.radCharacterCake);
            this.grpTypeOfCake.Controls.Add(this.radCustomCake);
            this.grpTypeOfCake.Location = new System.Drawing.Point(22, 207);
            this.grpTypeOfCake.Margin = new System.Windows.Forms.Padding(4);
            this.grpTypeOfCake.Name = "grpTypeOfCake";
            this.grpTypeOfCake.Padding = new System.Windows.Forms.Padding(4);
            this.grpTypeOfCake.Size = new System.Drawing.Size(570, 108);
            this.grpTypeOfCake.TabIndex = 16;
            this.grpTypeOfCake.TabStop = false;
            this.grpTypeOfCake.Text = "Type of Cake";
            // 
            // radCharacterCake
            // 
            this.radCharacterCake.AutoSize = true;
            this.radCharacterCake.Location = new System.Drawing.Point(299, 53);
            this.radCharacterCake.Margin = new System.Windows.Forms.Padding(4);
            this.radCharacterCake.Name = "radCharacterCake";
            this.radCharacterCake.Size = new System.Drawing.Size(171, 29);
            this.radCharacterCake.TabIndex = 1;
            this.radCharacterCake.TabStop = true;
            this.radCharacterCake.Text = "Character Cake";
            this.radCharacterCake.UseVisualStyleBackColor = true;
            this.radCharacterCake.CheckedChanged += new System.EventHandler(this.radCharacterCake_CheckedChanged);
            // 
            // radCustomCake
            // 
            this.radCustomCake.AutoSize = true;
            this.radCustomCake.Location = new System.Drawing.Point(20, 53);
            this.radCustomCake.Margin = new System.Windows.Forms.Padding(4);
            this.radCustomCake.Name = "radCustomCake";
            this.radCustomCake.Size = new System.Drawing.Size(153, 29);
            this.radCustomCake.TabIndex = 0;
            this.radCustomCake.TabStop = true;
            this.radCustomCake.Text = "Custom Cake";
            this.radCustomCake.UseVisualStyleBackColor = true;
            this.radCustomCake.CheckedChanged += new System.EventHandler(this.radCustomCake_CheckedChanged);
            // 
            // lblChooseCharCake
            // 
            this.lblChooseCharCake.AutoSize = true;
            this.lblChooseCharCake.Location = new System.Drawing.Point(612, 264);
            this.lblChooseCharCake.Name = "lblChooseCharCake";
            this.lblChooseCharCake.Size = new System.Drawing.Size(235, 25);
            this.lblChooseCharCake.TabIndex = 18;
            this.lblChooseCharCake.Text = "Choose Character Cake: ";
            // 
            // lstCharCake
            // 
            this.lstCharCake.FormattingEnabled = true;
            this.lstCharCake.ItemHeight = 25;
            this.lstCharCake.Location = new System.Drawing.Point(615, 306);
            this.lstCharCake.Name = "lstCharCake";
            this.lstCharCake.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstCharCake.Size = new System.Drawing.Size(220, 229);
            this.lstCharCake.TabIndex = 19;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(855, 392);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(135, 44);
            this.btnView.TabIndex = 20;
            this.btnView.Text = "View Cart";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnClearCart
            // 
            this.btnClearCart.Location = new System.Drawing.Point(855, 482);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(135, 44);
            this.btnClearCart.TabIndex = 21;
            this.btnClearCart.Text = "Clear Cart";
            this.btnClearCart.UseVisualStyleBackColor = true;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // frmOrderCake
            // 
            this.AcceptButton = this.btnAddToCart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(1182, 586);
            this.Controls.Add(this.btnClearCart);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lstCharCake);
            this.Controls.Add(this.lblChooseCharCake);
            this.Controls.Add(this.grpTypeOfCake);
            this.Controls.Add(this.grpCustomCake);
            this.Controls.Add(this.grpCustInfo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.grpChoose);
            this.Controls.Add(this.btnAddToCart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "frmOrderCake";
            this.Text = "Carlos Carrilho - N01351778";
            this.grpChoose.ResumeLayout(false);
            this.grpNumLayers.ResumeLayout(false);
            this.grpNumLayers.PerformLayout();
            this.grpFlavour.ResumeLayout(false);
            this.grpFlavour.PerformLayout();
            this.grpCustInfo.ResumeLayout(false);
            this.grpCustInfo.PerformLayout();
            this.grpCustomCake.ResumeLayout(false);
            this.grpDesign.ResumeLayout(false);
            this.grpDesign.PerformLayout();
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            this.grpOccasion.ResumeLayout(false);
            this.grpOccasion.PerformLayout();
            this.grpTypeOfCake.ResumeLayout(false);
            this.grpTypeOfCake.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.GroupBox grpChoose;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpCustInfo;
        private System.Windows.Forms.GroupBox grpNumLayers;
        private System.Windows.Forms.RadioButton rad4layers;
        private System.Windows.Forms.RadioButton rad3layers;
        private System.Windows.Forms.RadioButton rad2layers;
        private System.Windows.Forms.RadioButton rad1layer;
        private System.Windows.Forms.GroupBox grpFlavour;
        private System.Windows.Forms.RadioButton radLemonBerry;
        private System.Windows.Forms.RadioButton radBanana;
        private System.Windows.Forms.RadioButton radVanilla;
        private System.Windows.Forms.RadioButton radChocolate;
        private System.Windows.Forms.GroupBox grpCustomCake;
        private System.Windows.Forms.GroupBox grpDesign;
        private System.Windows.Forms.RadioButton rad3D;
        private System.Windows.Forms.RadioButton radBow;
        private System.Windows.Forms.RadioButton radEdible;
        private System.Windows.Forms.RadioButton radPolka;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.RadioButton rad12inch;
        private System.Windows.Forms.RadioButton rad10inch;
        private System.Windows.Forms.RadioButton rad8inch;
        private System.Windows.Forms.RadioButton rad6inch;
        private System.Windows.Forms.GroupBox grpOccasion;
        private System.Windows.Forms.RadioButton radWedding;
        private System.Windows.Forms.RadioButton radRetirement;
        private System.Windows.Forms.RadioButton radBirthday;
        private System.Windows.Forms.RadioButton radAnniversary;
        private System.Windows.Forms.GroupBox grpTypeOfCake;
        private System.Windows.Forms.RadioButton radCharacterCake;
        private System.Windows.Forms.RadioButton radCustomCake;
        private System.Windows.Forms.Label lblChooseCharCake;
        private System.Windows.Forms.ListBox lstCharCake;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnClearCart;
    }
}

