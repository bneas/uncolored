namespace uncolored.controllers
{
	using FXML = javafx.fxml.FXML;
	using FXMLLoader = javafx.fxml.FXMLLoader;
	using Initializable = javafx.fxml.Initializable;
	using Node = javafx.scene.Node;
	using MouseEvent = javafx.scene.input.MouseEvent;
	using HBox = javafx.scene.layout.HBox;
	using VBox = javafx.scene.layout.VBox;

	/// 
	/// <summary>
	/// @author Benny
	/// </summary>
	public class DashboardController : Initializable
	{

//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @FXML private javafx.scene.layout.VBox content;
		private VBox content;

		internal VBox current, newAnalysis, savedAnalysis, baselineAnalysis, setting;

		public override void initialize(URL url, ResourceBundle rb)
		{
			try
			{
				current = FXMLLoader.load(this.GetType().getResource("/uncolored/views/Current.fxml"));
				newAnalysis = FXMLLoader.load(this.GetType().getResource("/uncolored/views/NewAnalysis.fxml"));
				savedAnalysis = FXMLLoader.load(this.GetType().getResource("/uncolored/views/SavedAnalysis.fxml"));
				baselineAnalysis = FXMLLoader.load(this.GetType().getResource("/uncolored/views/BaselineAnalysis.fxml"));
				setting = FXMLLoader.load(this.GetType().getResource("/uncolored/views/Setting.fxml"));
				content.Children.All = current;

			}
			catch (IOException ex)
			{
//JAVA TO C# CONVERTER WARNING: The .NET Type.FullName property will not always yield results identical to the Java Class.getName method:
				Logger.getLogger(typeof(DashboardController).FullName).log(Level.SEVERE, null, ex);
			}
		}

//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @FXML private void changeContent(javafx.scene.input.MouseEvent event)
		private void changeContent(MouseEvent @event)
		{
			content.Children.removeAll();

			HBox btn = (HBox)((Node) @event.Source);
			switch (btn.Id)
			{
				case "currentRisk":
					content.Children.All = current;
					break;
				case "nAnalysis":
					content.Children.All = newAnalysis;
					break;
				case "sAnalysis":
					content.Children.All = savedAnalysis;
					break;
				case "bAnalysis":
					content.Children.All = baselineAnalysis;
					break;
				case "setting":
					content.Children.All = setting;
					break;
			}
		}

	}

}