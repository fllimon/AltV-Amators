<script>
  export let car;
  export let selectedCar;
</script>

<style>
  .card {
    border: 2px solid #ccc;
    border-radius: 8px;
    padding: 16px;
    text-align: center;
    margin: 8px;
    cursor: pointer;
    transition: transform 0.2s, box-shadow 0.2s;
  }

  .card.selected {
    border-color: #ff3e00;
    box-shadow: 0 0 10px rgba(255, 62, 0, 0.5);
  }

  .card:hover {
    transform: scale(1.05);
  }
</style>

<!-- svelte-ignore a11y-click-events-have-key-events -->
<!-- svelte-ignore a11y-no-static-element-interactions -->
<div class="card {car === selectedCar ? 'selected' : ''}" on:click={() => selectedCar = car}>
  <h2>{car}</h2>
</div>
