package uncolored.main;

import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.stage.Stage;
import javafx.stage.StageStyle;

/**
 *
 * @author Benny
 */
public class Launch extends Application {

    @Override
    public void start(Stage stage) throws Exception {
        Parent root = FXMLLoader.load(getClass().getResource("/uncolored/views/Dashboard.fxml"));
        Scene scene = new Scene(root);
        stage.setScene(scene);
        stage.setTitle("Uncolored");
        stage.initStyle(StageStyle.UTILITY);
        stage.setMinWidth(980.0);
        stage.setMinHeight(680);
        stage.setWidth(980.0);
        stage.setHeight(680);
        stage.show();
    }

    public static void main(String[] args) {
        launch(args);
    }

}
