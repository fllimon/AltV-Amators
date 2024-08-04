<script>
	export let type;
	export let onclick;
	export let buttonText;	
</script>

<button {type} on:click={onclick} {...$$restProps}>
	<slot>{buttonText}</slot>
</button>

<style>

	button{
		display: inline-flex;
		height: 54px;
		width: 300px;
		padding: 6px 16px;
		align-items: center;
		gap: 51px;
		flex-shrink: 0;
		background: #343434;
		box-shadow: 0px 0px 15px 0px rgba(0, 0, 0, 0.15);
		color: #fff;
		font-size: 14px;
	}

</style>