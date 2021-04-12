using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.CSharp;
using System.CodeDom.Compiler;

namespace Simple_Code_Editor_1._6._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void OpenDlg()
        {
            OpenFileDialog of = new OpenFileDialog();
            if (richTextBox1.Language == FastColoredTextBoxNS.Language.CSharp)
                of.Filter = "C# File|*.cs|Any File|*.*";
            else if (richTextBox1.Language == FastColoredTextBoxNS.Language.VB)
                of.Filter = "VB File|*.vb|Any File|*.*";
            else if (richTextBox1.Language == FastColoredTextBoxNS.Language.JS)
                of.Filter = "JS File|*.js|Any File|*.*";
            else if (richTextBox1.Language == FastColoredTextBoxNS.Language.HTML)
                of.Filter = "HTML File|*.html|Any File|*.*";
            else if (richTextBox1.Language == FastColoredTextBoxNS.Language.PHP)
                of.Filter = "PHP File|*.php|Any File|*.*";
            else if (richTextBox1.Language == FastColoredTextBoxNS.Language.XML)
                of.Filter = "XML File|*.xml|Any File|*.*";
            else if (richTextBox1.Language == FastColoredTextBoxNS.Language.Lua)
                of.Filter = "Lua File|*.lua|Any File|*.*";
            else
                of.Filter = "Any File|*.*";
            if (of.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(of.FileName);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
                this.Text = "Simple Code Editor 1.6.3" + " (" + of.FileName + ")";
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDlg();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter(this.Text);
                sw.Write(richTextBox1.Text);
                sw.Close();
            }
            catch
            {
                OpenDlg();
            }
        }

        private void SaveDlg()
        {
            SaveFileDialog sf = new SaveFileDialog();
            if (richTextBox1.Language == FastColoredTextBoxNS.Language.CSharp)
                sf.Filter = "C# File|*.cs|Any File|*.*";
            else if (richTextBox1.Language == FastColoredTextBoxNS.Language.VB)
                sf.Filter = "VB File|*.vb|Any File|*.*";
            else if (richTextBox1.Language == FastColoredTextBoxNS.Language.JS)
                sf.Filter = "JS File|*.js|Any File|*.*";
            else if (richTextBox1.Language == FastColoredTextBoxNS.Language.HTML)
                sf.Filter = "HTML File|*.html|Any File|*.*";
            else if (richTextBox1.Language == FastColoredTextBoxNS.Language.PHP)
                sf.Filter = "PHP File|*.php|Any File|*.*";
            else if (richTextBox1.Language == FastColoredTextBoxNS.Language.XML)
                sf.Filter = "XML File|*.xml|Any File|*.*";
            else if (richTextBox1.Language == FastColoredTextBoxNS.Language.Lua)
                sf.Filter = "Lua File|*.lua|Any File|*.*";
            else
                sf.Filter = "Any File|*.*";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sr = new StreamWriter(sf.FileName);
                sr.Write(richTextBox1);
                sr.Close();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDlg();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.BackColor = cd.Color;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fd.Font;
            }
        }

        private void textColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = cd.Color;
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }



        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ShowFindDialog();
        }

        private void goToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ShowGoToDialog();
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ShowReplaceDialog();
        }

        private void hTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Language = FastColoredTextBoxNS.Language.HTML;
        }

        private void pHPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Language = FastColoredTextBoxNS.Language.PHP;
        }

        private void javaScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Language = FastColoredTextBoxNS.Language.JS;
        }

        private void sQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Language = FastColoredTextBoxNS.Language.SQL;
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Language = FastColoredTextBoxNS.Language.XML;
        }

        private void luaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Language = FastColoredTextBoxNS.Language.Lua;
        }

        private void vBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Language = FastColoredTextBoxNS.Language.VB;
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Language = FastColoredTextBoxNS.Language.CSharp;
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Language == FastColoredTextBoxNS.Language.HTML)
            {
                HTML_Preview h = new HTML_Preview(richTextBox1.Text);
                h.Show();
            }
            else if(richTextBox1.Language == FastColoredTextBoxNS.Language.CSharp)
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "Executable File|*.exe";
                string OutPath = "?.exe";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    OutPath = sf.FileName;
                }
                //compile code:
                //create c# code compiler
                CSharpCodeProvider codeProvider = new CSharpCodeProvider();
                //create new parameters for compilation and add references(libs) to compiled app
                CompilerParameters parameters = new CompilerParameters(new string[] { "System.dll" });
                //is compiled code will be executable?(.exe)
                parameters.GenerateExecutable = true;
                //output path
                parameters.OutputAssembly = OutPath;
                //code sources to compile
                string[] sources = { richTextBox1.Text };
                //results of compilation
                CompilerResults results = codeProvider.CompileAssemblyFromSource(parameters, sources);

                //if has errors
                if (results.Errors.Count > 0)
                {
                    string errsText = "";
                    foreach (CompilerError CompErr in results.Errors)
                    {
                        errsText = "(" + CompErr.ErrorNumber +
                                    ")Line " + CompErr.Line +
                                    ",Column " + CompErr.Column +
                                    ":" + CompErr.ErrorText + "" +
                                    Environment.NewLine;
                    }
                    //show error message
                    MessageBox.Show(errsText, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //run compiled app
                    System.Diagnostics.Process.Start(OutPath);
                }

            }
            else
            {
                MessageBox.Show("Cannot Run This FIle");
            }
        }
    }
}
