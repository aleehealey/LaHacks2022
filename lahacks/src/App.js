import './App.css';
import SignUp from './components/Login';
import ResponsiveAppBar from './components/Header';

export default function App() {
    return (
      <div className="App">
        {ResponsiveAppBar()}
        <h1> Hang out with your friends with no planning needed.</h1>
        {SignUp() }
      </div>
    );
}