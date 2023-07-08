
namespace WorldWeaver
{
    partial class NPCForm
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
            this.txtbxSTR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveNPC = new System.Windows.Forms.Button();
            this.groupBoxStats = new System.Windows.Forms.GroupBox();
            this.txtbxAC = new System.Windows.Forms.Label();
            this.textBxAC = new System.Windows.Forms.TextBox();
            this.txtbxHP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbxDEX = new System.Windows.Forms.Label();
            this.textBxDEX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbxCON = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblWIS = new System.Windows.Forms.Label();
            this.txtBxWIS = new System.Windows.Forms.TextBox();
            this.txtbxCHA = new System.Windows.Forms.TextBox();
            this.txtbxINT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.rtbxSkills = new System.Windows.Forms.RichTextBox();
            this.rtbxAbilities = new System.Windows.Forms.RichTextBox();
            this.rtbxAttacks = new System.Windows.Forms.RichTextBox();
            this.rtbxCharacterNotes = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnMain = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.npcnameBox = new System.Windows.Forms.TextBox();
            this.groupBoxStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbxSTR
            // 
            this.txtbxSTR.Location = new System.Drawing.Point(120, 23);
            this.txtbxSTR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxSTR.Name = "txtbxSTR";
            this.txtbxSTR.Size = new System.Drawing.Size(38, 26);
            this.txtbxSTR.TabIndex = 0;
            this.txtbxSTR.TextChanged += new System.EventHandler(this.txtbxSTR_TextChanged);
            this.txtbxSTR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxSTR_KeyPress_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Strength";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "NPC Creator";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnSaveNPC
            // 
            this.btnSaveNPC.Location = new System.Drawing.Point(168, 934);
            this.btnSaveNPC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveNPC.Name = "btnSaveNPC";
            this.btnSaveNPC.Size = new System.Drawing.Size(243, 35);
            this.btnSaveNPC.TabIndex = 6;
            this.btnSaveNPC.Text = "Save";
            this.btnSaveNPC.UseVisualStyleBackColor = true;
            this.btnSaveNPC.Click += new System.EventHandler(this.btnSaveNPC_Click);
            // 
            // groupBoxStats
            // 
            this.groupBoxStats.Controls.Add(this.npcnameBox);
            this.groupBoxStats.Controls.Add(this.label3);
            this.groupBoxStats.Controls.Add(this.txtbxAC);
            this.groupBoxStats.Controls.Add(this.textBxAC);
            this.groupBoxStats.Controls.Add(this.txtbxHP);
            this.groupBoxStats.Controls.Add(this.label9);
            this.groupBoxStats.Controls.Add(this.txtbxDEX);
            this.groupBoxStats.Controls.Add(this.textBxDEX);
            this.groupBoxStats.Controls.Add(this.label7);
            this.groupBoxStats.Controls.Add(this.txtbxCON);
            this.groupBoxStats.Controls.Add(this.label6);
            this.groupBoxStats.Controls.Add(this.lblWIS);
            this.groupBoxStats.Controls.Add(this.txtBxWIS);
            this.groupBoxStats.Controls.Add(this.txtbxCHA);
            this.groupBoxStats.Controls.Add(this.txtbxINT);
            this.groupBoxStats.Controls.Add(this.label4);
            this.groupBoxStats.Controls.Add(this.label1);
            this.groupBoxStats.Controls.Add(this.txtbxSTR);
            this.groupBoxStats.Location = new System.Drawing.Point(30, 80);
            this.groupBoxStats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxStats.Name = "groupBoxStats";
            this.groupBoxStats.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxStats.Size = new System.Drawing.Size(363, 252);
            this.groupBoxStats.TabIndex = 8;
            this.groupBoxStats.TabStop = false;
            this.groupBoxStats.Text = "NPC Stats";
            this.groupBoxStats.Enter += new System.EventHandler(this.groupBoxStats_Enter);
            // 
            // txtbxAC
            // 
            this.txtbxAC.AutoSize = true;
            this.txtbxAC.Location = new System.Drawing.Point(228, 163);
            this.txtbxAC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtbxAC.Name = "txtbxAC";
            this.txtbxAC.Size = new System.Drawing.Size(31, 20);
            this.txtbxAC.TabIndex = 15;
            this.txtbxAC.Text = "AC";
            // 
            // textBxAC
            // 
            this.textBxAC.Location = new System.Drawing.Point(268, 158);
            this.textBxAC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBxAC.Name = "textBxAC";
            this.textBxAC.Size = new System.Drawing.Size(38, 26);
            this.textBxAC.TabIndex = 14;
            this.textBxAC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox8_KeyPress);
            // 
            // txtbxHP
            // 
            this.txtbxHP.Location = new System.Drawing.Point(120, 158);
            this.txtbxHP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxHP.Name = "txtbxHP";
            this.txtbxHP.Size = new System.Drawing.Size(38, 26);
            this.txtbxHP.TabIndex = 13;
            this.txtbxHP.TextChanged += new System.EventHandler(this.txtbxHP_TextChanged);
            this.txtbxHP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxHP_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(74, 163);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "HP";
            // 
            // txtbxDEX
            // 
            this.txtbxDEX.AutoSize = true;
            this.txtbxDEX.Location = new System.Drawing.Point(190, 117);
            this.txtbxDEX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtbxDEX.Name = "txtbxDEX";
            this.txtbxDEX.Size = new System.Drawing.Size(68, 20);
            this.txtbxDEX.TabIndex = 11;
            this.txtbxDEX.Text = "dexterity";
            // 
            // textBxDEX
            // 
            this.textBxDEX.Location = new System.Drawing.Point(268, 112);
            this.textBxDEX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBxDEX.Name = "textBxDEX";
            this.textBxDEX.Size = new System.Drawing.Size(38, 26);
            this.textBxDEX.TabIndex = 10;
            this.textBxDEX.TextChanged += new System.EventHandler(this.TxtBxDEX);
            this.textBxDEX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxDEX);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 117);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Constitution ";
            // 
            // txtbxCON
            // 
            this.txtbxCON.Location = new System.Drawing.Point(120, 117);
            this.txtbxCON.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxCON.Name = "txtbxCON";
            this.txtbxCON.Size = new System.Drawing.Size(38, 26);
            this.txtbxCON.TabIndex = 8;
            this.txtbxCON.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxCON_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 72);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "charisma ";
            // 
            // lblWIS
            // 
            this.lblWIS.AutoSize = true;
            this.lblWIS.Location = new System.Drawing.Point(192, 72);
            this.lblWIS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWIS.Name = "lblWIS";
            this.lblWIS.Size = new System.Drawing.Size(66, 20);
            this.lblWIS.TabIndex = 6;
            this.lblWIS.Text = "Wisdom";
            // 
            // txtBxWIS
            // 
            this.txtBxWIS.Location = new System.Drawing.Point(268, 68);
            this.txtBxWIS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBxWIS.Name = "txtBxWIS";
            this.txtBxWIS.Size = new System.Drawing.Size(38, 26);
            this.txtBxWIS.TabIndex = 5;
            this.txtBxWIS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBxWIS);
            // 
            // txtbxCHA
            // 
            this.txtbxCHA.Location = new System.Drawing.Point(120, 68);
            this.txtbxCHA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxCHA.Name = "txtbxCHA";
            this.txtbxCHA.Size = new System.Drawing.Size(38, 26);
            this.txtbxCHA.TabIndex = 4;
            this.txtbxCHA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxCHA_KeyPress);
            // 
            // txtbxINT
            // 
            this.txtbxINT.Location = new System.Drawing.Point(268, 22);
            this.txtbxINT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbxINT.Name = "txtbxINT";
            this.txtbxINT.Size = new System.Drawing.Size(38, 26);
            this.txtbxINT.TabIndex = 3;
            this.txtbxINT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxINT_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Intelligence";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 351);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Skills";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 723);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Attacks ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 537);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "Abilities";
            // 
            // rtbxSkills
            // 
            this.rtbxSkills.Location = new System.Drawing.Point(18, 375);
            this.rtbxSkills.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbxSkills.Name = "rtbxSkills";
            this.rtbxSkills.Size = new System.Drawing.Size(428, 155);
            this.rtbxSkills.TabIndex = 13;
            this.rtbxSkills.Text = "";
            // 
            // rtbxAbilities
            // 
            this.rtbxAbilities.Location = new System.Drawing.Point(15, 562);
            this.rtbxAbilities.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbxAbilities.Name = "rtbxAbilities";
            this.rtbxAbilities.Size = new System.Drawing.Size(430, 155);
            this.rtbxAbilities.TabIndex = 14;
            this.rtbxAbilities.Text = "";
            // 
            // rtbxAttacks
            // 
            this.rtbxAttacks.Location = new System.Drawing.Point(15, 748);
            this.rtbxAttacks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbxAttacks.Name = "rtbxAttacks";
            this.rtbxAttacks.Size = new System.Drawing.Size(430, 155);
            this.rtbxAttacks.TabIndex = 15;
            this.rtbxAttacks.Text = "";
            // 
            // rtbxCharacterNotes
            // 
            this.rtbxCharacterNotes.Location = new System.Drawing.Point(458, 102);
            this.rtbxCharacterNotes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbxCharacterNotes.Name = "rtbxCharacterNotes";
            this.rtbxCharacterNotes.Size = new System.Drawing.Size(301, 441);
            this.rtbxCharacterNotes.TabIndex = 16;
            this.rtbxCharacterNotes.Text = "";
            this.rtbxCharacterNotes.TextChanged += new System.EventHandler(this.richTextBox5_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(448, 55);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 20);
            this.label14.TabIndex = 17;
            this.label14.Text = "Character notes";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(537, 934);
            this.btnMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(112, 35);
            this.btnMain.TabIndex = 18;
            this.btnMain.Text = "Main Menu";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "NPC Name";
            // 
            // npcnameBox
            // 
            this.npcnameBox.Location = new System.Drawing.Point(120, 203);
            this.npcnameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.npcnameBox.Name = "npcnameBox";
            this.npcnameBox.Size = new System.Drawing.Size(91, 26);
            this.npcnameBox.TabIndex = 17;
            // 
            // NPCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 988);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.rtbxCharacterNotes);
            this.Controls.Add(this.rtbxAttacks);
            this.Controls.Add(this.rtbxAbilities);
            this.Controls.Add(this.rtbxSkills);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBoxStats);
            this.Controls.Add(this.btnSaveNPC);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NPCForm";
            this.Text = "NPC Creation";
            this.Load += new System.EventHandler(this.NPCForm_Load);
            this.groupBoxStats.ResumeLayout(false);
            this.groupBoxStats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxSTR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveNPC;
        private System.Windows.Forms.GroupBox groupBoxStats;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtbxAC;
        private System.Windows.Forms.TextBox textBxAC;
        private System.Windows.Forms.TextBox txtbxHP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txtbxDEX;
        private System.Windows.Forms.TextBox textBxDEX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbxCON;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblWIS;
        private System.Windows.Forms.TextBox txtBxWIS;
        private System.Windows.Forms.TextBox txtbxCHA;
        private System.Windows.Forms.TextBox txtbxINT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox rtbxSkills;
        private System.Windows.Forms.RichTextBox rtbxAbilities;
        private System.Windows.Forms.RichTextBox rtbxAttacks;
        private System.Windows.Forms.RichTextBox rtbxCharacterNotes;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.TextBox npcnameBox;
        private System.Windows.Forms.Label label3;
    }
}