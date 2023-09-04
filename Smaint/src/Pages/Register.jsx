import React, { useState } from "react";
import axios from "axios";
import TextField from "@mui/material/TextField";
import Button from "@mui/material/Button";
import Container from "@mui/material/Container";
import Grid from "@mui/material/Grid";

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
    <Container maxWidth="sm">
      <form onSubmit={handleSubmit}>
        <Grid container spacing={2}>
          <Grid item xs={12} sm={6}>
            <TextField
              fullWidth
              variant="outlined"
              label="Name"
              name="Name"
              value={formData.Name}
              onChange={handleChange}
              InputLabelProps={{
                shrink: true,
                style: { color: "0f6466" }, // Customize placeholder color
              }}
            />
          </Grid>
          <Grid item xs={12} sm={6}>
            <TextField
              fullWidth
              variant="outlined"
              label="Surname"
              name="Surname"
              value={formData.Surname}
              onChange={handleChange}
              InputLabelProps={{
                shrink: true,
                style: { color: "0f6466" }, // Customize placeholder color
              }}
            />
          </Grid>
          <Grid item xs={12}>
            <TextField
              fullWidth
              variant="outlined"
              label="Username"
              name="UserName"
              value={formData.UserName}
              onChange={handleChange}
              InputLabelProps={{
                shrink: true,
                style: { color: "0f6466" }, // Customize placeholder color
              }}
            />
          </Grid>
          <Grid item xs={12}>
            <TextField
              fullWidth
              variant="outlined"
              label="Email"
              name="Email"
              type="email"
              value={formData.Email}
              onChange={handleChange}
              InputLabelProps={{
                shrink: true,
                style: { color: "0f6466" }, // Customize placeholder color
              }}
            />
          </Grid>
          <Grid item xs={12}>
            <TextField
              fullWidth
              variant="outlined"
              label="Password"
              name="Password"
              type="password"
              value={formData.Password}
              onChange={handleChange}
              InputLabelProps={{
                shrink: true,
                style: { color: "0f6466" }, // Customize placeholder color
              }}
            />
          </Grid>
          <Grid item xs={12}>
            <TextField
              fullWidth
              variant="outlined"
              label="ConfirmPassword"
              name="ConfirmPassword"
              type="ConfirmPassword"
              value={formData.ConfirmPassword}
              onChange={handleChange}
              InputLabelProps={{
                shrink: true,
                style: { color: "b#0f6466;" }, // Customize placeholder color
              }}
            />
          </Grid>
        </Grid>
        <Button type="submit" variant="contained" color="primary" fullWidth>
          Register
        </Button>
      </form>
    </Container>
  );
};

export default Register;
