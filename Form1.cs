using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NewSoft.Framework.MicaLibrary;
using static NewSoft.Framework.MicaLibrary.ParameterTypes;
using static NewSoft.Framework.MicaLibrary.MicaEffectMethods;
using NewSoft.Framework;


namespace Newspoint_Software_System_Information
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region"LoadSetting"
            Form me = this;
            MicaLibrary.LoadMicaSet.ApplyEffectAllForm(ref me, Color.Maroon, 0, 3);
            PublicFunctions.WinFormFunctionStyle.FormTitle(me, "Newspoint Software - System Information");
            PublicFunctions.WinFormFunctionStyle.FormStartPositions(me, "center screen");
            #endregion
            #region"LoadInfoSystem"
            #endregion
            #region"LoadMainInfo"
            #endregion
        }
    }
}
