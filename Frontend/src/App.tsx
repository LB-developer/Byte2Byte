import './App.css'

export default function App() {
    
    const fetchSomething = async () => {
      try {
          const res = await fetch("https://localhost:7176/api/v1/RandomNumber")
            
          if (res.status != 200) {
              throw new Error("Response status was not 200 when fetching the weather forecast")
          }
          
          let json = await res.json()
          
          console.log(json)
      } catch (e) {
         console.error("Couldn't fetch or parse the response for fetch", e) 
      }
    }

  return (
    <>
      <div className="card">
        <button onClick={fetchSomething}>
        </button>
      </div>
    </>
  )
}


