namespace SampleCsPanel
{
  ///<summary>
  /// Every RhinoCommon plug-in must have one and only one Rhino.PlugIns.PlugIn
  /// inherited class. DO NOT create instances of this class yourself. It is the
  /// responsibility of Rhino to create an instance of this class.
  ///</summary>
  public class SampleCsPanelPlugIn : Rhino.PlugIns.PlugIn
  {
    /// <summary>
    /// Public constructor
    /// </summary>
    public SampleCsPanelPlugIn()
    {
      Instance = this;
    }

    /// <summary>
    /// The only instance of this plug-in.
    /// </summary>
    public static SampleCsPanelPlugIn Instance
    {
      get;
      private set;
    }

    // You can override methods here to change the plug-in behavior on
    // loading and shut down, add options pages to the Rhino _Option command
    // and mantain plug-in wide options in a document.

    /// <summary>
    /// Is called when the plug-in is being loaded.
    /// </summary>
    protected override Rhino.PlugIns.LoadReturnCode OnLoad(ref string errorMessage)
    {
      System.Type panelType = typeof(SampleCsPanelUserControl);
      Rhino.UI.Panels.RegisterPanel(this, panelType, "Sample", System.Drawing.SystemIcons.Question);

      return Rhino.PlugIns.LoadReturnCode.Success;
    }

    /// <summary>
    /// The tabbed dockbar user control
    /// </summary>
    public SampleCsPanelUserControl UserControl
    {
      get;
      set;
    }
  }
}