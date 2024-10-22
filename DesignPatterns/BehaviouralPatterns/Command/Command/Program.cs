using Command;

Camera camera = new Camera();

ControlPanel controlPanel = new ControlPanel(camera);
controlPanel.Activate();
controlPanel.RotateCamera(true, false, false, false);
controlPanel.RotateCamera(false, true, false, false);
controlPanel.RotateCamera(false, false, true, false);
controlPanel.RotateCamera(false, false, false, true);
controlPanel.DeActivate();
