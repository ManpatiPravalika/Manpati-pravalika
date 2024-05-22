* {
    padding: 0;
    margin: 0;
  }

  html{
      background-color: #d9f4ff;
  }

  hr {
      height: 2px;
      background-color: aqua;
  }

  h1{
      text-align: center;
      color: #42474b;
      height: 25px;
      font-size: 50px;
      padding: 35px;
  }

  .wrapper {
    display: grid;
    height: 600px;
    grid-template-rows: 100px 3fr;
    grid-template-columns: 4fr;
    grid-gap: 1px;

  }

  .buttons {
    display: grid;
    grid-template-rows: repeat(5, 1fr);
    grid-template-columns: repeat(4, 1fr);
    grid-gap: 4px;

  }

  .container {
    width: 425px;
    height: 600px;
    border: 2px solid black;
    border-radius: 10px;
    background-color: #000000;
    margin: 0 auto;
    padding: auto;
    box-shadow: 0px 0px 0px 15px rgba(0, 0, 0, 2);
  }

  .inputArea {
    background-color: #5b6d7c;
    grid-column: 1/2;
    display: block;
  }

  input[type="text"] {
    box-sizing: border-box;
    margin-top: 10px;
    margin-left: 10px;
    padding-top: 30px;
    padding-right: 38px;
    padding-bottom: 10px;
    font-size: 30px;
    background-color: rgb(218, 216, 216);
    text-align: right;
    border: 2px solid rgb(37, 37, 37);
    border-radius: 8px;
  }
/*   
  input[type=button]:hover {
    background-color: #8c8c8c;
  } */

  input[type="text"]:disabled {
    color:#000000;
  }

  .btnr1 {
    background: #25292c;
    text-align: center;
    width: 102px;
  }

  .btnr2 {
    background: #13171d;
    text-align: center;
    width: 102px;
  }

  .btnr1 > input {
    background: transparent;
    border: none;
    justify-content: center;
    align-self: end;
    color: white;
    font-size: 2.5em;
    margin-top: 25px;
  }

  .btnr2 > input {
    background: transparent;
    border: none;
    justify-content: center;
    align-self: end;
    color: white;
    font-size: 2.5em;
    margin-top: 25px;
  }

  .btnC > input {
    color: #ff7a00 !important;
  }

  body{
    width: 100%;
    height: 100vh;
    background: url('new\ pic.jpg')no-repeat;
    background-size: cover;
    display: flex;
    justify-content: center;
    align-items: center;
    font-size: 1rem;
  }