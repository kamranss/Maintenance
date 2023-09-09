import React, { useState } from "react";
import { NavLink } from "react-router-dom";
import axios from "axios";
import TextField from "@mui/material/TextField";
import Button from "@mui/material/Button";
import Container from "@mui/material/Container";
import Grid from "@mui/material/Grid";
import Box from "@mui/material/Box"; // Added Box for margin and padding

const Login = () => {
  const [formData, setFormData] = useState({
    UserName: "",
    Password: "",
  });

  const handleChange = (e) => {
    const { name, value } = e.target;
    setFormData({ ...formData, [name]: value });
  };

  const handleSubmit = async (e) => {
    e.preventDefault();

    try {
      const response = await axios.post("/api/auth/login", formData);
      console.log("Login successful", response);
      // Redirect to a different page upon successful login
      // Example: window.location.href = "/dashboard";
    } catch (error) {
      console.error("Login error", error);
    }
  };

  return (
    <Container className="login_Container" maxWidth="sm">
      <form onSubmit={handleSubmit}>
        <Grid container spacing={2}>
          <Grid item xs={12}>
            <Box mb={2}>
              {" "}
              {/* Added margin-bottom */}
              <TextField
                fullWidth
                variant="outlined"
                label="Username"
                name="UserName"
                value={formData.UserName}
                onChange={handleChange}
                InputLabelProps={{
                  shrink: true,
                  style: { color: "#0f6466" }, // Customize placeholder color
                }}
              />
            </Box>
          </Grid>
          <Grid item xs={12}>
            <Box mb={2}>
              {" "}
              {/* Added margin-bottom */}
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
                  style: { color: "#0f6466" }, // Customize placeholder color
                }}
              />
            </Box>
          </Grid>
        </Grid>
        <Box mt={2}>
          {" "}
          {/* Added margin-top */}
          <Button type="submit" variant="contained" color="primary" fullWidth>
            Login
          </Button>
        </Box>
      </form>
      <Box mt={2} textAlign="center">
        <NavLink to="/Register">
          Don't have an account?{" "}
          <span className="register_here">Register here</span>
        </NavLink>
      </Box>
    </Container>
  );
};

export default Login;
