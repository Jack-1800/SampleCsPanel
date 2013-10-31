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
  /// <summary>
  /// This is the user control that is buried in the tabbed, docking panel.
  /// </summary>
  [System.Runtime.InteropServices.Guid("83D6FCC8-4F31-4AE3-BF60-C6528DB232D0")]
  public partial class SampleCsPanelUserControl : UserControl
  {
    /// <summary>
    /// Public constructor
    /// </summary>
    public SampleCsPanelUserControl()
    {
      InitializeComponent();

      // Set the user control property on our plug-in
      SampleCsPanelPlugIn.Instance.UserControl = this;

      // Create a visible changed event handler
      this.VisibleChanged += new EventHandler(SampleCsPanelUserControl_VisibleChanged);

      // Create a dispose event handler
      this.Disposed += new EventHandler(SampleCsPanelUserControl_Disposed);
    }

    void SampleCsPanelUserControl_VisibleChanged(object sender, EventArgs e)
    {
    }

    /// <summary>
    /// Occurs when the component is disposed by a call to the
    /// System.ComponentModel.Component.Dispose() method.
    /// </summary>
    void SampleCsPanelUserControl_Disposed(object sender, EventArgs e)
    {
      // Clear the user control property on our plug-in
      SampleCsPanelPlugIn.Instance.UserControl = null;
    }

    /// <summary>
    /// Returns the ID of this panel.
    /// </summary>
    public static System.Guid PanelId
    {
      get
      {
        return typeof(SampleCsPanelUserControl).GUID;
      }
    }
  }
}
