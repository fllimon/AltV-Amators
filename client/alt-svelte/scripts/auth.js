import * as alt from 'alt-client';

let loginCef;

alt.onServer('Event.Auth', () => {
    loginCef = new alt.WebView('http://resources/client/alt-svelte/public/index.html');
    loginCef.focus();

    console.log("Event.Auth sucessfuly entered");

    alt.showCursor(true);
    alt.toggleGameControls(false);
    alt.toggleVoiceControls(false);

    loginCef.on('Auth.Login', (login, password) =>{
        console.log('loginCef.on - Auth.Login');
        alt.emitServer('Event.Login', login, password)
    })

    loginCef.on('Auth.Register', (login, password, email) =>{
        console.log('loginCef.on - Auth.Register');
        alt.emitServer('Event.Register', login, password, email)
    })

    console.log("Event.Auth - exited");
});

alt.onServer('CloseLoginCEF', () => {
    alt.showCursor(false);
    alt.toggleGameControls(true);
    alt.toggleVoiceControls(true);

    if(loginCef){
        loginCef.destroy();
    }
});
