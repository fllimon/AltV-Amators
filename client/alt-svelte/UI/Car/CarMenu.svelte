<script>
    import CarCard from './CarCard.svelte';
    import Button from '../Controls/Button.svelte';
    import IoIosArrowRoundForward from 'svelte-icons/io/IoIosArrowRoundForward.svelte';

    let selectedCar = '';
    let cars = ['Toyota', 'Honda', 'Ford', 'BMW', 'Mercedes'];
  
    function handleSubmit(event) {
      event.preventDefault();
      alert(`Selected: ${selectedCar}`);
    }
  </script>

  <div class="conteiner">
    <div class="cards">
      {#each cars as car}
        <CarCard {car} bind:selectedCar={selectedCar} />
      {/each}
    </div>
    <div class="button">
        <Button type='submit' buttonText='' onclick={handleSubmit} disabled={!selectedCar}>Арендовать <span class="icon"><IoIosArrowRoundForward class="icon"></IoIosArrowRoundForward></span></Button>
    </div>
  </div>

  <style>
    .conteiner {
      display: flex;
      flex-direction: column;
      align-items: flex-start;
      background-color: darkgray;
      border: 2px #ccc;
      width: 600px;
      height: 400px;
      border-radius: 8px;
    }
  
    .cards{
      display: flex;
      flex-wrap: wrap;
      justify-content: center;
      gap: 16px;
      max-width: 600px;
    }

    .button{
        padding: 16px 0 0 50px;
    }

    .icon {
    margin-left: auto;
    height: 40px;
    width: 40px;
    color: #e40763;
    }      
    /* button {
      margin-top: 20px;
      padding: 10px 20px;
      background-color: #ff3e00;
      color: white;
      border: none;
      border-radius: 8px;
      cursor: pointer;
      transition: background-color 0.2s;
    }
  
    button:hover {
      background-color: #e63600;
    } */
  </style>
  