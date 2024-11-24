import './App.css'

export default function App() {
    
    const fetchLoops = async () => {
      try {
          const res = await fetch("https://localhost:7176/api/v1/Loops",
              {
                  method: "POST",
              })
            
          if (res.status != 201) {
              throw new Error("Response status was not 201 when creating the placeholder")
          }
          
          console.log("Created placeholder")
      } catch (e) {
         console.error(e) 
      }
    }

  return (
    <>
        <ul>
            <li>Loops
            <button onClick={fetchLoops}> Fetch Loops</button>
            </li>
            <li>Conditionals</li>
            <li>Methods</li>
        </ul>
    </>
  )
}


