namespace uncolored.main
{
	using Application = javafx.application.Application;
	using FXMLLoader = javafx.fxml.FXMLLoader;
	using Parent = javafx.scene.Parent;
	using Scene = javafx.scene.Scene;
	using Stage = javafx.stage.Stage;
	using StageStyle = javafx.stage.StageStyle;

	/// 
	/// <summary>
	/// @author Benny
	/// </summary>
	public class Launch : Application
	{

//JAVA TO C# CONVERTER WARNING: Method 'throws' clauses are not available in C#:
//ORIGINAL LINE: public void start(javafx.stage.Stage stage) throws Exception
		public override void start(Stage stage)
		{
			Parent root = FXMLLoader.load(this.GetType().getResource("/uncolored/views/Dashboard.fxml"));
			Scene scene = new Scene(root);
			stage.Scene = scene;
			stage.Title = "Uncolored";
			stage.initStyle(StageStyle.UTILITY);
			stage.MinWidth = 980.0;
			stage.MinHeight = 680;
			stage.Width = 980.0;
			stage.Height = 680;
			stage.show();
		}

		public static void Main(string[] args)
		{
			launch(args);
		}

	}

}