:root {
  --bg-main: #f0f2f5;
  --bg-body: #fff;
  --color-txt: #000;
  --filled-color: #000;
  --filled-bg: #caf0f8;

  --white: #fff;
  --blue: #00aeef;
  --red: #e91e63;
  --black: #000;

  --nav-size: 70px;
  --sudoku-cell-size: 50px;

  --border-radius: 10px;

  --space-y: 20px;

  --gap: 5px;

  --font-size: 1.5rem;
  --font-size-lg: 2rem;
  --font-size-xl: 3rem;
}

.dark {
  --bg-main: #2a2a38;
  --bg-body: #1a1a2e;
  --color-txt: #6a6a6a;
  --filled-color: #4f4f63;
  --filled-bg: #000;
}

* {
  padding: 0;
  margin: 0;
  box-sizing: border-box;
  -webkit-tap-highlight-color: transparent;
}

body {
  font-family: sans-serif, cursive;
  /* height: 100vh; */
  background-color: var(--bg-body);
  overflow-x: hidden;
  user-select: none;
}

input {
  font-family: sans-serif, cursive;
  border: 2px solid var(--bg-main);
  color: var(--color-txt);
}

input:hover,
input:focus {
  border-color: var(--blue);
}

a {
  text-decoration: none;
  color: unset;
}

ul {
  list-style-type: none;
}

nav {
  background-color: var(--bg-body);
  color: var(--color-txt);
  position: fixed;
  top: 0;
  width: 100%;
  box-shadow: 5px 2px var(--bg-main);
  z-index: 99;
}

.nav-container {
  max-width: 1280px;
  margin: auto;
  display: flex;
  align-items: center;
  justify-content: space-between;
  padding: 0 40px;
  height: var(--nav-size);
}

.nav-logo {
  font-size: var(--font-size-lg);
  color: var(--blue);
}

.dark-mode-toggle {
  color: var(--blue);
  font-size: var(--font-size-lg);
  cursor: pointer;
}

.bxs-sun {
  display: none;
}

.bxs-moon {
  display: inline-block;
}

.dark .bxs-sun {
  display: inline-block;
}

.dark .bxs-moon {
  display: none;
}

.main {
  /* height: 100vh; */
  padding-top: var(--nav-size);
  display: grid;
  place-items: center;
}

.screen {
  position: relative;
  overflow: hidden;
  height: 100%;
  min-width: 400px;
}

.start-screen {
  position: absolute;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  transform: translateX(-100%);
  transition: transform 0.3s ease-in-out;
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
}

.start-screen.active {
  transform: translateX(0);
}

.start-screen > * + * {
  margin-top: 20px;
}

.input-name {
  height: 80px;
  width: 280px;
  border-radius: var(--border-radius);
  outline: 0;
  background-color: var(--bg-main);
  padding: 20px;
  font-size: var(--font-size-lg);
  text-align: center;
}

.btn {
  height: 80px;
  width: 280px;
  background-color: var(--bg-main);
  color: var(--color-txt);
  border-radius: var(--border-radius);
  display: grid;
  place-items: center;
  transition: width 0.3s ease-in-out;
  overflow: hidden;
  font-size: var(--font-size-lg);
  cursor: pointer;
}

.btn-blue {
  background-color: var(--blue);
  color: var(--white);
}

.input-err {
  border-color: var(--red);
  animation: bounce 0.5s cubic-bezier(0.175, 0.885, 0.32, 1.275);
}

@keyframes bounce {
  0% {
    transform: translateX(0);
  }
  25% {
    transform: translateX(20px);
  }
  50% {
    transform: translateX(-20px);
  }
  100% {
    transform: translateX(0);
  }
}

.main-game {
  display: flex;
  height: 100%;
  flex-direction: column;
  justify-content: space-between;
  padding: 30px 0;
  transform: translateX(100%);
  transition: transform 0.3s ease-in-out;
}

.main-game.active {
  transform: translateX(0);
}

.main-sudoku-grid {
  display: grid;
  gap: var(--gap);
  grid-template-columns: repeat(9, auto);
}

.main-grid-cell {
  height: var(--sudoku-cell-size);
  width: var(--sudoku-cell-size);
  border-radius: var(--border-radius);
  background-color: var(--bg-main);
  color: var(--blue);
  display: grid;
  place-items: center;
  font-size: var(--font-size);
  cursor: pointer;
}

.main-grid-cell.filled {
  background-color: var(--filled-bg);
  color: var(--filled-color);
}

.main-grid-cell.selected {
  background-color: var(--blue);
  color: var(--white);
}

.main-grid-cell:hover {
  border: 2px solid var(--blue);
}

.main-grid-cell.hover {
  border: 3px solid var(--blue);
}

.dark .main-grid-cell.hover {
  border: 1px solid var(--blue);
}

.main-grid-cell.err {
  background-color: var(--red);
  color: var(--white);
}

.main-game-info {
  margin-top: var(--space-y);
  margin-bottom: 10px;
  display: grid;
  grid-template-columns: 1fr 1fr;
  gap: 10px;
}

.main-game-info-box {
  height: 45px;
  background-color: var(--bg-main);
  color: var(--color-txt);
  border-radius: var(--border-radius);
  display: grid;
  place-items: center;
  padding: 0 20px;
  font-size: var(--font-size);
}

.main-game-info-time {
  position: relative;
  align-items: center;
  justify-content: center;
  padding-left: 2rem;
  margin-bottom: auto;
}

.pause-btn {
  position: absolute;
  right: 10px;
  height: 30px;
  width: 30px;
  border-radius: var(--border-radius);
  background-color: var(--blue);
  color: var(--white);
  font-size: var(--font-size);
  display: grid;
  place-items: center;
  cursor: pointer;
}

.numbers {
  margin-top: var(--space-y);
  display: grid;
  grid-template-columns: repeat(5, 1fr);
  gap: 5px;
}

.number {
  height: var(--sudoku-cell-size);
  border-radius: var(--border-radius);
  background-color: var(--bg-main);
  color: var(--color-txt);
  display: grid;
  place-items: center;
  font-size: var(--font-size);
  cursor: pointer;
}

.delete {
  background-color: var(--red);
  color: var(--white);
  height: var(--sudoku-cell-size);
  border-radius: var(--border-radius);
  display: grid;
  place-items: center;
  font-size: var(--font-size);
  cursor: pointer;
}

.pause-screen,
.result-screen {
  position: absolute;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  background-color: var(--bg-body);
  align-items: center;
  justify-content: center;
  flex-direction: column;
  display: none;
}

.pause-screen.active,
.result-screen.active {
  display: flex;
}

.pause-screen > * + *,
.result-screen > * + * {
  margin-top: 20px;
}

.result-screen.active div {
  animation: zoom-in 0.5s cubic-bezier(0.175, 0.885, 0.32, 1.275);
}

.pause-screen.active .btn {
  animation: zoom-in 0.5s cubic-bezier(0.175, 0.885, 0.32, 1.275);
}

.result-screen .congrate {
  font-size: var(--font-size-xl);
  color: var(--blue);
}

.result-screen .info {
  color: var(--color-txt);
  font-size: var(--font-size);
}

#result-time {
  color: var(--blue);
  font-size: var(--font-size-xl);
}

.zoom-in {
  animation: zoom-in 0.5s cubic-bezier(0.175, 0.885, 0.32, 1.275);
}

@keyframes zoom-in {
  0% {
    transform: scale(3);
  }
  100% {
    transform: scale(1);
  }
}

.cell-err {
  animation: zoom-out-shake 0.5s cubic-bezier(0.175, 0.885, 0.32, 1.275);
}

@keyframes zoom-out-shake {
  0% {
    transform: scale(2);
  }
  25% {
    transform: scale(2) rotate(30deg);
  }
  50% {
    transform: scale(2) rotate(-30deg);
  }
  100% {
    transform: scale(1);
  }
}

@media only screen and (max-width: 800px) {
  :root {
    --nav-size: 50px;

    --sudoku-cell-size: 30px;

    --border-radius: 5px;

    --space-y: 10px;

    --gap: 2px;

    --font-size: 1rem;
    --font-size-lg: 1.5rem;
    --font-size-xl: 2rem;
  }

  .input-name,
  .btn {
    height: 50px;
  }

  .main-grid-cell.hover {
    border-width: 2px;
  }

  .screen {
    min-width: unset;
  }

  .main {
    height: 100vh;
  }
}
