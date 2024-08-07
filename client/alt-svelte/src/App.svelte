<script>
	import { writable } from 'svelte/store';
	import Auth from '../UI/Auth/Auth.svelte';
	import CarMenu from '../UI/Car/CarMenu.svelte';

	const views = {
		Auth,
		CarMenu
	};
	export const selectedView = writable('CarMenu');

	alt.on('setActiveView', (view) =>{
		selectedView.set(view);
	});
	
</script>

<svelte:component this={views[$selectedView]} />

<style>
</style>