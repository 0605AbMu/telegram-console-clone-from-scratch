namespace TelegramClient.Auth.UI;

public class ActiveUi
{
        LoginUI loginUi;
        RegistraionUI registraionUi;
        
    public void ActiveUI()
    {

        
    }

    public ActiveUi()
    {
        loginUi = new LoginUI();
        registraionUi = new RegistraionUI();
        
    }
    
}