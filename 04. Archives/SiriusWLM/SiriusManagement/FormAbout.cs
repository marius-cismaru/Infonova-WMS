using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Security.Principal;
using System.Linq;

namespace Sirius.SiriusManagement
{
	public partial class FormAbout : Form
	{
		public FormAbout()
		{
			InitializeComponent();
            Text = Settings.GetProgramNameFull() + " - Despre";
            labelProgramName.Text = Configuration.Main.AssemblyNameLong;
            labelProgramDescription.Text = Settings.ProgramDescription;
            labelVersionProgram.Text = "Program: " + Settings.GetProgramVersion() + ", update " + Settings.ProgramUpdateDate;
            labelVersionDatabase.Text = "Interfata baza de date: " + Configuration.Main.GetDatabaseVersion();
            labelAuthor.Text = "Creat de " + Configuration.Main.AssemblyAuthor;
            richTextBoxUpdateLog.Text = string.Join(Environment.NewLine, Settings.ProgramUpdateLog);
		}
	}
}