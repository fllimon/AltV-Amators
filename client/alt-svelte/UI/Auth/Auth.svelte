<script>
	import Button from "../Controls/Button.svelte";
	import IoIosArrowRoundForward from 'svelte-icons/io/IoIosArrowRoundForward.svelte';

	let username = '';
	let registrationPassword = '';
	let registrationconfirmPassword = '';
	let email = '';

	let login ='';
	let password = '';

function LoginUser(){
	event.preventDefault();
    console.log('login: ' + login + ' ' + 'password: ' + password)
	if (!("alt" in window)){
		console.log('aborted');
		return;	
	}

    alt.emit('Auth.Login', login, password);
}

function RegisterUser(){
	event.preventDefault();
    if (registrationPassword === registrationconfirmPassword) {
		if (!("alt" in window)){
			console.log('aborted');
			return;	
		}

        alt.emit('Auth.Register', username, registrationPassword, email);			
    }

    alert('Password do not match!');
}

</script>

<body>
	<div class="header-registration-container">
		<!-- svelte-ignore a11y-missing-attribute -->
		<div class="line-container">
			<svg
				xmlns="http://www.w3.org/2000/svg"
				width="469"
				height="545"
				viewBox="0 0 469 545"
				fill="none"
			>
				<g filter="url(#filter0_b_2_16)">
					<path
						d="M469 543H407C386.013 543 369 525.987 369 505V40C369 19.0132 351.987 2 331 2H0.5"
						stroke="url(#paint0_linear_2_16)"
						stroke-width="4"
					/>
				</g>
				<defs>
					<filter
						id="filter0_b_2_16"
						x="-16.5"
						y="-17"
						width="502.5"
						height="579"
						filterUnits="userSpaceOnUse"
						color-interpolation-filters="sRGB"
					>
						<feFlood flood-opacity="0" result="BackgroundImageFix" />
						<feGaussianBlur in="BackgroundImageFix" stdDeviation="8.5" />
						<feComposite
							in2="SourceAlpha"
							operator="in"
							result="effect1_backgroundBlur_2_16"
						/>
						<feBlend
							mode="normal"
							in="SourceGraphic"
							in2="effect1_backgroundBlur_2_16"
							result="shape"
						/>
					</filter>
					<linearGradient
						id="paint0_linear_2_16"
						x1="238.75"
						y1="2"
						x2="238.75"
						y2="543"
						gradientUnits="userSpaceOnUse"
					>
						<stop stop-color="#323232" />
						<stop offset="1" stop-color="#5D9275" stop-opacity="0.05" />
					</linearGradient>
				</defs>
			</svg>
		</div>
	</div>
	<div class="container">
		<div class="registration-container">
			<div class="logo-container">
				<div class="logo">
					<p>GTA PROJECT</p>
				</div>
				<h1>AMATORS RP</h1>
			</div>
			<div class="description-container">
				<h2>Регистрация аккаунта</h2>
				<p>
					Регистрируя аккаунт на нашем проекте, настоятельно рекомендуем ознакомиться с <a
						href="https://google.com"
						style="color:#5D9275;">правилами проекта.</a
					>
				</p>
			</div>
			<form>
				<div class="input-group">
					<div class="input-container">
						<label class="login-label" for="login-input">Придумайте логин</label>
						<input class="login-input" placeholder="username" bind:value={username} />
					</div>
					<div class="input-container">
						<label class="password-label" for="password-input"
							>Придумайте пароль</label
						>
						<input class="password-input" type="password" placeholder="password" bind:value={registrationPassword} />
					</div>
					<div class="input-container">
						<label class="confirm-password-label" for="confirm-password-input"
							>Подтвердите пароль</label
						>
						<input class="confirm-password-input" type="password" placeholder="password" bind:value={registrationconfirmPassword} />
					</div>
					<div class="input-container">
						<label class="email-label" for="email-input">Введите Ваш e-mail</label>
						<input class="email-input" type="email" placeholder="amators@gmail.com" bind:value={email}/>
					</div>
					<div class="rules-container">
						<p>Внимание! Продолжая регистрацию вы автоматически соглашаетесь с правилами нашего проекта. 
							Если вы еще не ознакомлены с ними обязательно <a href="https://google.com" style="color:#5D9275;"> ознакомьтесь.</a></p>
					</div>
				</div>
				<div class="button-submit">
					<Button onclick={RegisterUser}> Продолжить регистрацию <span class="icon"><IoIosArrowRoundForward class="icon"></IoIosArrowRoundForward></span></Button>
				</div>
			</form>
		</div>
	</div>

	<div class="back-img"></div>
	<div class="auth-container">
		<div class="authorization-container">
			<div class="auth-description">
				<h2>Выполните вход в аккаунта</h2>
				<p>
					У вас возникли проблемы с входом в аккаунт? 
					Вы можете открыть тикет на <a href="https://google.com" style="color:#5D9275;"> нашем форуме </a> для восстановления аккаунта.
				</p>
			</div>
			<form>
				<div class="input-group">
					<div class="input-container">
						<label class="login-label" for="login-input">Введите логин</label>
						<input class="login-input" placeholder="username" bind:value={login}/>
					</div>
					<div class="input-container">
						<label class="password-label" for="password-input"
							>Введите пароль</label
						>
						<input class="password-input" type="password" placeholder="password" bind:value={password}/>
					</div>
				</div>
				<div class="auth-button-submit">
					<Button onclick={LoginUser}> Продолжить <span class="icon"><IoIosArrowRoundForward class="icon"></IoIosArrowRoundForward></span></Button>
				</div>
			</form>
		</div>
	</div>
</body>

<style lang="css">
body {
    font-family: 'Roboto', sans-serif;
	background-color: #918a94
}

.container{
    width: 855px;
    height: 725px;
    display: inline-flex;
    margin-right: 100px;
}

.logo-container {
    display: block;
    flex-direction: column;
    align-items: center;
}

.logo {
    width: 117px;
    height: 29px;
    flex-shrink: 0;
    border-radius: 6px;
    background: #e40763;
    margin: 44px 0 0 44px;
    margin-bottom: 10px;
    display: flex;
    align-items: center;
    justify-content: center;
    color: #fff;
}

h1 {
    font-family: Gilroy;
    font-size: 37.579px;
    font-style: normal;
    font-weight: 900;
    line-height: normal;
    background: linear-gradient(90deg, #e40763 0%, #ca6ae0 100%);
    background-clip: text;
    -webkit-background-clip: text;
    -webkit-text-fill-color: transparent;
    margin: 10px 0 0 44px;
}

.description-container {
    width: 400px;
    height: 32px;
    flex-shrink: 0;
    margin: 20px 0 0 53px;
}

p {
	width: 100%;
    color: #fff;
    font-family: Gilroy;
    font-size: 15px;
    font-style: normal;
    font-weight: 500;
    line-height: normal;
}

h2 {
    color: #eaeaf5;
    font-family: Gilroy;
    font-size: 24px;
    font-style: normal;
    font-weight: 700;
    line-height: normal;
}
.registration-container {
    position: absolute;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
    background-size: cover;
    width: 734px;
    height: 725px;
    flex-shrink: 0;
    border: 1px solid #000;
    margin: 170px 0 0 150px;
    background: linear-gradient(
        91deg,
        rgba(50, 50, 50, 0.76) 0.84%,
        rgba(93, 146, 117, 0.04) 104.41%
    );
    backdrop-filter: blur(5.5px);
}
.header-registration-container {
    width: 426.239px;
    height: 30px;
    flex-shrink: 0;
    margin: 70px;
    box-sizing: border-box;
}

.line-container {
    width: 468.5px;
    height: 541px;
    flex-shrink: 0;
    stroke-width: 4px;
    stroke: #323232;
    backdrop-filter: blur(8.5px);
    margin-left: 547.5px;
}

input {
    display: inline-block;
    width: 383px;
    height: 49px;
    font: inherit;
    border: none;
    border-left: 4px solid #ccc;
    border-radius: 3px 3px 0 0;
    background: rgba(52, 52, 52, 0.68);
    margin-left: 5px;
    padding: 0.25rem 0.25rem;
    transition: border-color 0.1s ease-out;
}

input:focus {
    border-color: #e40763;
    outline: none;
    color: #fff;
}

label {
    flex: 1;
    width: 100%;
	color: #fff
}

.input-container {
    display: flex;
    padding: 0.5rem 0;
    align-items: center;
}

.input-group{
    width: 630px;
    margin: 70px auto;
}

.rules-container{
    width: 660px;
    height: 54px;
    flex-shrink: 0;
}

.icon{
    margin-left: auto;
    height: 40px;
    width: 40px;
    color: #e40763;
}

.button-submit{
    margin: -30px 0 0 50px;
}

.auth-button-submit{
    margin: -15px 0 0 50px;
}

.auth-container{
    width: 734px;
    height: 421px;
    flex-shrink: 0;
    background: linear-gradient(
        91deg,
        rgba(50, 50, 50, 0.76) 0.84%,
        rgba(93, 146, 117, 0.04) 104.41%
    );
    backdrop-filter: blur(6.5px);
    margin: -300px 0 0 1120px
}

.authorization-container{
    position: absolute;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
    background-size: cover;
}

.auth-description {
    width: 400px;
    height: 32px;
    flex-shrink: 0;
    margin: 30px 0 0 50px
}

.back-img{
    position: absolute;
    width: 786px;
    height: 965px;
    flex-shrink: 0;
    background: url('../images/back.png'), rgba(211, 211, 211, 0) 50% / cover no-repeat;
    margin: -750px 0 0 1120px
}
</style>