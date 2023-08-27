import React from 'react'
import { NavLink } from 'react-router-dom'

const Home = () => {
    return (
    <div className="department">
      <NavLink className="icon" to="/">
        <span className="span">Home</span>      
      </NavLink>
      <NavLink className="icon" to="/department">
      <span className="span">Home</span> 
      </NavLink>
      <NavLink className="icon" to="/department">
      <span className="span">Home</span> 
      </NavLink>
      <NavLink className="icon" to="/department">
      <span className="span">Departments</span> 
      </NavLink>
      <NavLink className="icon" to="/department">
      <span className="span">Departments</span> 
      </NavLink>
    </div>
    )
}

export default Home