import App from './App.svelte';

if (!("alt" in globalThis)) {
	// @ts-ignore shut
	globalThis.alt = {
	  emit: (eventName, ...args) => {
		console.log(`Event: ${eventName}`, args);
	  },
	  on: (eventName, ...args) => {
		console.log(`Registered event: ${eventName}`);
	  },
	};
}

const app = new App({
	target: document.body,
});

export default app;