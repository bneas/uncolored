namespace uncolored.controllers
{
	using ActionEvent = javafx.@event.ActionEvent;
	using FXML = javafx.fxml.FXML;
	using FXMLLoader = javafx.fxml.FXMLLoader;
	using Initializable = javafx.fxml.Initializable;
	using VBox = javafx.scene.layout.VBox;

	public class NewAnalysisController : Initializable
	{

//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @FXML private javafx.scene.layout.VBox vbox;
		private VBox vbox;
		private VBox nextFxml;

		public override void initialize(URL url, ResourceBundle rb)
		{
			try
			{
				// TODO
				nextFxml = FXMLLoader.load(this.GetType().getResource("/uncolored/views/NewAnalysis_1.fxml"));
			}
			catch (IOException ex)
			{
//JAVA TO C# CONVERTER WARNING: The .NET Type.FullName property will not always yield results identical to the Java Class.getName method:
				Logger.getLogger(typeof(NewAnalysisController).FullName).log(Level.SEVERE, null, ex);
			}
		}

//JAVA TO C# CONVERTER TODO TASK: Most Java annotations will not have direct .NET equivalent attributes:
//ORIGINAL LINE: @FXML private void next(javafx.event.ActionEvent event)
		private void next(ActionEvent @event)
		{
			vbox.Children.clear();
			vbox.Children.All = nextFxml;
		}

	}

}