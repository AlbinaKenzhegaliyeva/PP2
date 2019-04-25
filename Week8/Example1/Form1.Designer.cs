namespace Example1
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
			this.Clear_Memory = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button15 = new System.Windows.Forms.Button();
			this.button16 = new System.Windows.Forms.Button();
			this.button17 = new System.Windows.Forms.Button();
			this.button18 = new System.Windows.Forms.Button();
			this.Call_Memory = new System.Windows.Forms.Button();
			this.button20 = new System.Windows.Forms.Button();
			this.button21 = new System.Windows.Forms.Button();
			this.button22 = new System.Windows.Forms.Button();
			this.button23 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button14 = new System.Windows.Forms.Button();
			this.button24 = new System.Windows.Forms.Button();
			this.button25 = new System.Windows.Forms.Button();
			this.button26 = new System.Windows.Forms.Button();
			this.button27 = new System.Windows.Forms.Button();
			this.button28 = new System.Windows.Forms.Button();
			this.button29 = new System.Windows.Forms.Button();
			this.button30 = new System.Windows.Forms.Button();
			this.button31 = new System.Windows.Forms.Button();
			this.button32 = new System.Windows.Forms.Button();
			this.button33 = new System.Windows.Forms.Button();
			this.button34 = new System.Windows.Forms.Button();
			this.button35 = new System.Windows.Forms.Button();
			this.button36 = new System.Windows.Forms.Button();
			this.button37 = new System.Windows.Forms.Button();
			this.button38 = new System.Windows.Forms.Button();
			this.button39 = new System.Windows.Forms.Button();
			this.button40 = new System.Windows.Forms.Button();
			this.button41 = new System.Windows.Forms.Button();
			this.button42 = new System.Windows.Forms.Button();
			this.button43 = new System.Windows.Forms.Button();
			this.button44 = new System.Windows.Forms.Button();
			this.button46 = new System.Windows.Forms.Button();
			this.button47 = new System.Windows.Forms.Button();
			this.button49 = new System.Windows.Forms.Button();
			this.button50 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Clear_Memory
			// 
			this.Clear_Memory.Location = new System.Drawing.Point(61, 89);
			this.Clear_Memory.Name = "Clear_Memory";
			this.Clear_Memory.Size = new System.Drawing.Size(61, 33);
			this.Clear_Memory.TabIndex = 0;
			this.Clear_Memory.Text = "MC";
			this.Clear_Memory.UseVisualStyleBackColor = false;
			this.Clear_Memory.Click += new System.EventHandler(this.Clear_Memory_Click);
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(61, 27);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(454, 56);
			this.textBox1.TabIndex = 13;
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textBox1.Click += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// button15
			// 
			this.button15.Location = new System.Drawing.Point(61, 128);
			this.button15.Name = "button15";
			this.button15.Size = new System.Drawing.Size(86, 36);
			this.button15.TabIndex = 15;
			this.button15.Text = "CE";
			this.button15.UseVisualStyleBackColor = false;
			this.button15.Click += new System.EventHandler(this.CE_Click);
			// 
			// button16
			// 
			this.button16.Location = new System.Drawing.Point(333, 89);
			this.button16.Name = "button16";
			this.button16.Size = new System.Drawing.Size(61, 33);
			this.button16.TabIndex = 16;
			this.button16.Text = "MS";
			this.button16.UseVisualStyleBackColor = false;
			this.button16.Click += new System.EventHandler(this.Save_To_Memory_Click);
			// 
			// button17
			// 
			this.button17.Location = new System.Drawing.Point(266, 89);
			this.button17.Name = "button17";
			this.button17.Size = new System.Drawing.Size(61, 33);
			this.button17.TabIndex = 17;
			this.button17.Text = "M-";
			this.button17.UseVisualStyleBackColor = false;
			this.button17.Click += new System.EventHandler(this.Subtract_From_Memory_Click);
			// 
			// button18
			// 
			this.button18.Location = new System.Drawing.Point(199, 89);
			this.button18.Name = "button18";
			this.button18.Size = new System.Drawing.Size(61, 33);
			this.button18.TabIndex = 18;
			this.button18.Text = "M+";
			this.button18.UseVisualStyleBackColor = false;
			this.button18.Click += new System.EventHandler(this.Add_To_Memory_Click);
			// 
			// Call_Memory
			// 
			this.Call_Memory.Location = new System.Drawing.Point(128, 89);
			this.Call_Memory.Name = "Call_Memory";
			this.Call_Memory.Size = new System.Drawing.Size(61, 33);
			this.Call_Memory.TabIndex = 19;
			this.Call_Memory.Text = "MR";
			this.Call_Memory.UseVisualStyleBackColor = false;
			this.Call_Memory.Click += new System.EventHandler(this.Call_Memory_Click);
			// 
			// button20
			// 
			this.button20.Location = new System.Drawing.Point(429, 128);
			this.button20.Name = "button20";
			this.button20.Size = new System.Drawing.Size(86, 36);
			this.button20.TabIndex = 20;
			this.button20.Text = "XOR";
			this.button20.UseVisualStyleBackColor = false;
			this.button20.Click += new System.EventHandler(this.Bi_operations);
			// 
			// button21
			// 
			this.button21.Location = new System.Drawing.Point(337, 128);
			this.button21.Name = "button21";
			this.button21.Size = new System.Drawing.Size(86, 36);
			this.button21.TabIndex = 21;
			this.button21.Text = "1/x";
			this.button21.UseVisualStyleBackColor = false;
			this.button21.Click += new System.EventHandler(this.Mono_operations);
			// 
			// button22
			// 
			this.button22.Location = new System.Drawing.Point(153, 128);
			this.button22.Name = "button22";
			this.button22.Size = new System.Drawing.Size(86, 36);
			this.button22.TabIndex = 22;
			this.button22.Text = "C";
			this.button22.UseVisualStyleBackColor = false;
			this.button22.Click += new System.EventHandler(this.C_Click);
			// 
			// button23
			// 
			this.button23.Location = new System.Drawing.Point(245, 128);
			this.button23.Name = "button23";
			this.button23.Size = new System.Drawing.Size(86, 36);
			this.button23.TabIndex = 23;
			this.button23.Text = "⮾";
			this.button23.UseVisualStyleBackColor = false;
			this.button23.Click += new System.EventHandler(this.delete_last_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(61, 170);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(86, 36);
			this.button2.TabIndex = 24;
			this.button2.Text = "sqrt";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Mono_operations);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(61, 212);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(86, 36);
			this.button3.TabIndex = 25;
			this.button3.Text = "sinx";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Mono_operations);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(153, 212);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(86, 36);
			this.button4.TabIndex = 26;
			this.button4.Text = "cosx";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.Mono_operations);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(245, 212);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(86, 36);
			this.button5.TabIndex = 27;
			this.button5.Text = "tanx";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.Mono_operations);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(337, 212);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(86, 36);
			this.button6.TabIndex = 28;
			this.button6.Text = "cotx";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.Mono_operations);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(429, 170);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(86, 36);
			this.button7.TabIndex = 29;
			this.button7.Text = "binary";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.Mono_operations);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(337, 170);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(86, 36);
			this.button8.TabIndex = 30;
			this.button8.Text = "logxy";
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += new System.EventHandler(this.Bi_operations);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(245, 170);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(86, 36);
			this.button9.TabIndex = 31;
			this.button9.Text = "lnx";
			this.button9.UseVisualStyleBackColor = false;
			this.button9.Click += new System.EventHandler(this.Mono_operations);
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(153, 170);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(86, 36);
			this.button10.TabIndex = 32;
			this.button10.Text = "sqrt^x";
			this.button10.UseVisualStyleBackColor = false;
			this.button10.Click += new System.EventHandler(this.Bi_operations);
			// 
			// button11
			// 
			this.button11.Location = new System.Drawing.Point(61, 254);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(86, 36);
			this.button11.TabIndex = 33;
			this.button11.Text = "x^2";
			this.button11.UseVisualStyleBackColor = false;
			this.button11.Click += new System.EventHandler(this.Mono_operations);
			// 
			// button12
			// 
			this.button12.Location = new System.Drawing.Point(337, 254);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(86, 36);
			this.button12.TabIndex = 34;
			this.button12.Text = "x^y";
			this.button12.UseVisualStyleBackColor = false;
			this.button12.Click += new System.EventHandler(this.Bi_operations);
			// 
			// button13
			// 
			this.button13.Location = new System.Drawing.Point(245, 254);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(86, 36);
			this.button13.TabIndex = 35;
			this.button13.Text = "e^x";
			this.button13.UseVisualStyleBackColor = false;
			this.button13.Click += new System.EventHandler(this.Mono_operations);
			// 
			// button14
			// 
			this.button14.Location = new System.Drawing.Point(429, 254);
			this.button14.Name = "button14";
			this.button14.Size = new System.Drawing.Size(86, 36);
			this.button14.TabIndex = 36;
			this.button14.Text = "lcm";
			this.button14.UseVisualStyleBackColor = false;
			this.button14.Click += new System.EventHandler(this.Bi_operations);
			// 
			// button24
			// 
			this.button24.Location = new System.Drawing.Point(245, 296);
			this.button24.Name = "button24";
			this.button24.Size = new System.Drawing.Size(86, 36);
			this.button24.TabIndex = 37;
			this.button24.Text = "mod";
			this.button24.UseVisualStyleBackColor = false;
			this.button24.Click += new System.EventHandler(this.Bi_operations);
			// 
			// button25
			// 
			this.button25.Location = new System.Drawing.Point(61, 296);
			this.button25.Name = "button25";
			this.button25.Size = new System.Drawing.Size(86, 36);
			this.button25.TabIndex = 38;
			this.button25.Text = "%";
			this.button25.UseVisualStyleBackColor = false;
			this.button25.Click += new System.EventHandler(this.Bi_operations);
			// 
			// button26
			// 
			this.button26.Location = new System.Drawing.Point(153, 254);
			this.button26.Name = "button26";
			this.button26.Size = new System.Drawing.Size(86, 36);
			this.button26.TabIndex = 39;
			this.button26.Text = "10^x";
			this.button26.UseVisualStyleBackColor = false;
			this.button26.Click += new System.EventHandler(this.Mono_operations);
			// 
			// button27
			// 
			this.button27.Location = new System.Drawing.Point(429, 212);
			this.button27.Name = "button27";
			this.button27.Size = new System.Drawing.Size(86, 36);
			this.button27.TabIndex = 40;
			this.button27.Text = "gcd";
			this.button27.UseVisualStyleBackColor = false;
			this.button27.Click += new System.EventHandler(this.Bi_operations);
			// 
			// button28
			// 
			this.button28.Location = new System.Drawing.Point(153, 296);
			this.button28.Name = "button28";
			this.button28.Size = new System.Drawing.Size(86, 36);
			this.button28.TabIndex = 41;
			this.button28.Text = "x!";
			this.button28.UseVisualStyleBackColor = false;
			this.button28.Click += new System.EventHandler(this.Mono_operations);
			// 
			// button29
			// 
			this.button29.Location = new System.Drawing.Point(245, 338);
			this.button29.Name = "button29";
			this.button29.Size = new System.Drawing.Size(86, 36);
			this.button29.TabIndex = 42;
			this.button29.Text = "9";
			this.button29.UseVisualStyleBackColor = false;
			this.button29.Click += new System.EventHandler(this.Enter_Numbers);
			// 
			// button30
			// 
			this.button30.Location = new System.Drawing.Point(61, 464);
			this.button30.Name = "button30";
			this.button30.Size = new System.Drawing.Size(86, 36);
			this.button30.TabIndex = 43;
			this.button30.Text = "±";
			this.button30.UseVisualStyleBackColor = false;
			this.button30.Click += new System.EventHandler(this.change_sign_Click);
			// 
			// button31
			// 
			this.button31.Location = new System.Drawing.Point(429, 296);
			this.button31.Name = "button31";
			this.button31.Size = new System.Drawing.Size(86, 36);
			this.button31.TabIndex = 44;
			this.button31.Text = "Prime";
			this.button31.UseVisualStyleBackColor = false;
			this.button31.Click += new System.EventHandler(this.Bi_operations);
			// 
			// button32
			// 
			this.button32.Location = new System.Drawing.Point(337, 296);
			this.button32.Name = "button32";
			this.button32.Size = new System.Drawing.Size(86, 36);
			this.button32.TabIndex = 45;
			this.button32.Text = "÷";
			this.button32.UseVisualStyleBackColor = false;
			this.button32.Click += new System.EventHandler(this.Bi_operations);
			// 
			// button33
			// 
			this.button33.Location = new System.Drawing.Point(153, 338);
			this.button33.Name = "button33";
			this.button33.Size = new System.Drawing.Size(86, 36);
			this.button33.TabIndex = 46;
			this.button33.Text = "8";
			this.button33.UseVisualStyleBackColor = false;
			this.button33.Click += new System.EventHandler(this.Enter_Numbers);
			// 
			// button34
			// 
			this.button34.Location = new System.Drawing.Point(61, 422);
			this.button34.Name = "button34";
			this.button34.Size = new System.Drawing.Size(86, 36);
			this.button34.TabIndex = 47;
			this.button34.Text = "1";
			this.button34.UseVisualStyleBackColor = false;
			this.button34.Click += new System.EventHandler(this.Enter_Numbers);
			// 
			// button35
			// 
			this.button35.Location = new System.Drawing.Point(61, 380);
			this.button35.Name = "button35";
			this.button35.Size = new System.Drawing.Size(86, 36);
			this.button35.TabIndex = 48;
			this.button35.Text = "4";
			this.button35.UseVisualStyleBackColor = false;
			this.button35.Click += new System.EventHandler(this.Enter_Numbers);
			// 
			// button36
			// 
			this.button36.Location = new System.Drawing.Point(61, 338);
			this.button36.Name = "button36";
			this.button36.Size = new System.Drawing.Size(86, 36);
			this.button36.TabIndex = 49;
			this.button36.Text = "7";
			this.button36.UseVisualStyleBackColor = false;
			this.button36.Click += new System.EventHandler(this.Enter_Numbers);
			// 
			// button37
			// 
			this.button37.Location = new System.Drawing.Point(153, 422);
			this.button37.Name = "button37";
			this.button37.Size = new System.Drawing.Size(86, 36);
			this.button37.TabIndex = 50;
			this.button37.Text = "2";
			this.button37.UseVisualStyleBackColor = false;
			this.button37.Click += new System.EventHandler(this.Enter_Numbers);
			// 
			// button38
			// 
			this.button38.Location = new System.Drawing.Point(429, 380);
			this.button38.Name = "button38";
			this.button38.Size = new System.Drawing.Size(86, 36);
			this.button38.TabIndex = 51;
			this.button38.Text = "Fibonacci";
			this.button38.UseVisualStyleBackColor = false;
			this.button38.Click += new System.EventHandler(this.Bi_operations);
			// 
			// button39
			// 
			this.button39.Location = new System.Drawing.Point(337, 380);
			this.button39.Name = "button39";
			this.button39.Size = new System.Drawing.Size(86, 36);
			this.button39.TabIndex = 52;
			this.button39.Text = "-";
			this.button39.UseVisualStyleBackColor = false;
			this.button39.Click += new System.EventHandler(this.Bi_operations);
			// 
			// button40
			// 
			this.button40.Location = new System.Drawing.Point(245, 380);
			this.button40.Name = "button40";
			this.button40.Size = new System.Drawing.Size(86, 36);
			this.button40.TabIndex = 53;
			this.button40.Text = "6";
			this.button40.UseVisualStyleBackColor = false;
			this.button40.Click += new System.EventHandler(this.Enter_Numbers);
			// 
			// button41
			// 
			this.button41.Location = new System.Drawing.Point(153, 380);
			this.button41.Name = "button41";
			this.button41.Size = new System.Drawing.Size(86, 36);
			this.button41.TabIndex = 54;
			this.button41.Text = "5";
			this.button41.UseVisualStyleBackColor = false;
			this.button41.Click += new System.EventHandler(this.Enter_Numbers);
			// 
			// button42
			// 
			this.button42.Location = new System.Drawing.Point(429, 338);
			this.button42.Name = "button42";
			this.button42.Size = new System.Drawing.Size(86, 36);
			this.button42.TabIndex = 55;
			this.button42.Text = "Palin";
			this.button42.UseVisualStyleBackColor = false;
			this.button42.Click += new System.EventHandler(this.Bi_operations);
			// 
			// button43
			// 
			this.button43.Location = new System.Drawing.Point(337, 338);
			this.button43.Name = "button43";
			this.button43.Size = new System.Drawing.Size(86, 36);
			this.button43.TabIndex = 56;
			this.button43.Text = "x";
			this.button43.UseVisualStyleBackColor = false;
			this.button43.Click += new System.EventHandler(this.Bi_operations);
			// 
			// button44
			// 
			this.button44.Location = new System.Drawing.Point(153, 464);
			this.button44.Name = "button44";
			this.button44.Size = new System.Drawing.Size(86, 36);
			this.button44.TabIndex = 57;
			this.button44.Text = "0";
			this.button44.UseVisualStyleBackColor = false;
			this.button44.Click += new System.EventHandler(this.Enter_Numbers);
			// 
			// button46
			// 
			this.button46.Location = new System.Drawing.Point(337, 422);
			this.button46.Name = "button46";
			this.button46.Size = new System.Drawing.Size(86, 36);
			this.button46.TabIndex = 59;
			this.button46.Text = "+";
			this.button46.UseVisualStyleBackColor = false;
			this.button46.Click += new System.EventHandler(this.Bi_operations);
			// 
			// button47
			// 
			this.button47.Location = new System.Drawing.Point(245, 422);
			this.button47.Name = "button47";
			this.button47.Size = new System.Drawing.Size(86, 36);
			this.button47.TabIndex = 60;
			this.button47.Text = "3";
			this.button47.UseVisualStyleBackColor = false;
			this.button47.Click += new System.EventHandler(this.Enter_Numbers);
			// 
			// button49
			// 
			this.button49.Location = new System.Drawing.Point(337, 464);
			this.button49.Name = "button49";
			this.button49.Size = new System.Drawing.Size(86, 36);
			this.button49.TabIndex = 62;
			this.button49.Text = "=";
			this.button49.UseVisualStyleBackColor = false;
			this.button49.Click += new System.EventHandler(this.Equal_Click);
			// 
			// button50
			// 
			this.button50.Location = new System.Drawing.Point(245, 464);
			this.button50.Name = "button50";
			this.button50.Size = new System.Drawing.Size(86, 36);
			this.button50.TabIndex = 63;
			this.button50.Text = ",";
			this.button50.UseVisualStyleBackColor = false;
			this.button50.Click += new System.EventHandler(this.point_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(546, 519);
			this.Controls.Add(this.button50);
			this.Controls.Add(this.button49);
			this.Controls.Add(this.button47);
			this.Controls.Add(this.button46);
			this.Controls.Add(this.button44);
			this.Controls.Add(this.button43);
			this.Controls.Add(this.button42);
			this.Controls.Add(this.button41);
			this.Controls.Add(this.button40);
			this.Controls.Add(this.button39);
			this.Controls.Add(this.button38);
			this.Controls.Add(this.button37);
			this.Controls.Add(this.button36);
			this.Controls.Add(this.button35);
			this.Controls.Add(this.button34);
			this.Controls.Add(this.button33);
			this.Controls.Add(this.button32);
			this.Controls.Add(this.button31);
			this.Controls.Add(this.button30);
			this.Controls.Add(this.button29);
			this.Controls.Add(this.button28);
			this.Controls.Add(this.button27);
			this.Controls.Add(this.button26);
			this.Controls.Add(this.button25);
			this.Controls.Add(this.button24);
			this.Controls.Add(this.button14);
			this.Controls.Add(this.button13);
			this.Controls.Add(this.button12);
			this.Controls.Add(this.button11);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button23);
			this.Controls.Add(this.button22);
			this.Controls.Add(this.button21);
			this.Controls.Add(this.button20);
			this.Controls.Add(this.Call_Memory);
			this.Controls.Add(this.button18);
			this.Controls.Add(this.button17);
			this.Controls.Add(this.button16);
			this.Controls.Add(this.button15);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.Clear_Memory);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Clear_Memory;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.Button button16;
		private System.Windows.Forms.Button button17;
		private System.Windows.Forms.Button button18;
		private System.Windows.Forms.Button Call_Memory;
		private System.Windows.Forms.Button button20;
		private System.Windows.Forms.Button button21;
		private System.Windows.Forms.Button button22;
		private System.Windows.Forms.Button button23;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.Button button24;
		private System.Windows.Forms.Button button25;
		private System.Windows.Forms.Button button26;
		private System.Windows.Forms.Button button27;
		private System.Windows.Forms.Button button28;
		private System.Windows.Forms.Button button29;
		private System.Windows.Forms.Button button30;
		private System.Windows.Forms.Button button31;
		private System.Windows.Forms.Button button32;
		private System.Windows.Forms.Button button33;
		private System.Windows.Forms.Button button34;
		private System.Windows.Forms.Button button35;
		private System.Windows.Forms.Button button36;
		private System.Windows.Forms.Button button37;
		private System.Windows.Forms.Button button38;
		private System.Windows.Forms.Button button39;
		private System.Windows.Forms.Button button40;
		private System.Windows.Forms.Button button41;
		private System.Windows.Forms.Button button42;
		private System.Windows.Forms.Button button43;
		private System.Windows.Forms.Button button44;
		private System.Windows.Forms.Button button46;
		private System.Windows.Forms.Button button47;
		private System.Windows.Forms.Button button49;
		private System.Windows.Forms.Button button50;
	}
}

