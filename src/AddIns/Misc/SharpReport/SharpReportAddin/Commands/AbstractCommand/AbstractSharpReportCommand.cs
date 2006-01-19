//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.2032
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using System;

using ICSharpCode.Core;
using ICSharpCode.SharpDevelop;
using ICSharpCode.SharpDevelop.Gui;
	
/// <summary>
/// Abstract Class to give access to Sharpreport Designer
/// </summary>
/// <remarks>
/// 	created by - Forstmeier Peter
/// 	created on - 25.01.2005 11:46:09
/// </remarks>
namespace SharpReportAddin.Commands {
	public abstract class AbstractSharpReportCommand : AbstractMenuCommand {
		SharpReportView view = null;
		
		/// <summary>
		/// get a instance of SharpReportView
		/// </summary>
		/// 
		protected AbstractSharpReportCommand() : base() {
			try {
				view = (SharpReportView)WorkbenchSingleton.Workbench.ActiveWorkbenchWindow.ViewContent;
				if (view == null) {
					throw new NullReferenceException ("AbstractSharpCommand : No view available");
				}
			} catch (Exception) {
				throw;
			}
		}
		
		/// <summary>
		/// Enabled or disabled the command
		/// <remarks> /remarks>
		/// </summary>				
		public override bool IsEnabled
		{
			get
			{
				if (view != null) {
					return true;
				}
				return false;
			}			
			set{}
		}
		
		
		#region property'S
		public SharpReportView View {
			get {
				return view;
			}
		}
		#endregion
	}
}
