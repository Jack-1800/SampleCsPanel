using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SampleCsPanel
{
  // TODO: Create your own Guid for this class
  [System.Runtime.InteropServices.Guid("83D6FCC8-4F31-4AE3-BF60-C6528DB232D0")]
  public partial class SampleCsPanelUserControl : UserControl
  {
    public SampleCsPanelUserControl()
    {
      InitializeComponent();
    }

    public static System.Guid PanelId
    {
      get
      {
        return typeof(SampleCsPanelUserControl).GUID;
      }
    }

    /// <summary>
    /// http://msdn.microsoft.com/en-us/library/system.windows.forms.control.previewkeydown(v=vs.100).aspx
    /// Some key presses, such as the TAB, RETURN, ESC, and arrow keys, are typically ignored by some controls
    /// because they are not considered input key presses. By handling the PreviewKeyDown event and setting the
    /// IsInputKey property to true, you can raise the KeyDown event. Unfortunately, this does does not work
    /// for user controls buried in a tabbed, docking panel.
    /// </summary>
    private void textBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
    {
      switch (e.KeyCode)
      {
        case Keys.Tab:
        case Keys.Return:
        case Keys.Down:
        case Keys.Up:
        case Keys.Left:
        case Keys.Right:
          e.IsInputKey = true;
          break;
      }
    }
  }
}
