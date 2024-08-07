import * as alt from 'alt-client';
import { isStringNullOrEmpty } from 'natives';


let menuCEF = new alt.WebView('http://resources/client/alt-svelte/public/index.html');;

alt.onServer('Event.Auth', () => {
    menuCEF.focus();

    console.log("Event.Auth sucessfuly entered - localhost");

    alt.showCursor(true);
    alt.toggleGameControls(false);
    alt.toggleVoiceControls(false);

    menuCEF.on('Auth.Login', (login, password) =>{
        console.log('loginCef.on - Auth.Login');
        alt.emitServer('Event.Login', login, password)
    })

    menuCEF.on('Auth.Register', (login, password, email) =>{
        console.log('loginCef.on - Auth.Register');
        alt.emitServer('Event.Register', login, password, email)
    })

    console.log("Event.Auth - exited");
});

alt.onServer('CloseLoginCEF', () => {
    alt.showCursor(false);
    alt.toggleGameControls(true);
    alt.toggleVoiceControls(true);

    if(menuCEF){
        menuCEF.destroy();
    }
});

alt.onServer('Event.ChangeActiveView', (view) =>{
    console.log('Event.ChangeActiveView - entered: ' + view);

    if (isStringNullOrEmpty(view)) {
        console.log('Event.ChangeActiveView - empty')

        return;
    }

    menuCEF.emit('setActiveView', view);
});