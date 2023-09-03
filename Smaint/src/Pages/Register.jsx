import React, { useState } from "react";
import axios from "axios";

const Register = () => {
  const [formData, setFormData] = useState({
    Name: "",
    Surname: "",
    UserName: "",
    Email: "",
    Password: "",
  });

  const handleChange = (e) => {
    const { name, value } = e.target;
    setFormData({ ...formData, [name]: value });
  };

  const handleSubmit = async (e) => {
    e.preventDefault();

    try {
      const response = await axios.post("/api/auth/register", formData);
      console.log("Registration successful", response);
    } catch (error) {
      console.error("Registration error", error);
    }
  };

  return (
    <form onSubmit={handleSubmit}>
      <input
        type="text"
        name="Name"
        placeholder="Name"
        onChange={handleChange}
      />
      <input
        type="text"
        name="Surname"
        placeholder="Surname"
        onChange={handleChange}
      />
      <input
        type="text"
        name="UserName"
        placeholder="Username"
        onChange={handleChange}
      />
      <input
        type="email"
        name="Email"
        placeholder="Email"
        onChange={handleChange}
      />
      <input
        type="password"
        name="Password"
        placeholder="Password"
        onChange={handleChange}
      />
      <button type="submit">Register</button>
    </form>
  );
};

export default Register;
