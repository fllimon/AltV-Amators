<script>
	import { writable } from 'svelte/store';
	import Auth from '../UI/Auth/Auth.svelte';

	const views = {
		Auth
	};
	export const selectedView = writable('Auth');

	export const setActiveView = (view) => {
		selectedView.set(view);
	};
	
</script>

<svelte:component this={views[$selectedView]} />

<style>
</style>