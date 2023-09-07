import React from "react";
import Header from "./Components/Header.jsx";
import "./App.scss";
import {
  BrowserRouter as Router,
  Routes,
  Route,
  useLocation,
} from "react-router-dom";
// import Home from "./Pages/Home.jsx";
// import About from "./Pages/Department.jsx";
import HeaderNav from "./Components/HeaderNav.jsx";
import EquipmentPage from "./Pages/EquipmentPage.jsx";
import Departmment from "./Pages/Department.jsx";
import MpPage from "./Pages/MpPage.jsx";
import Administration from "./Pages/Administration.jsx";
import { CreateEquipment } from "./Pages/CreateEquipment.jsx";
import EquipmentDetail from "./Pages/EquipmentDetail.jsx";
import Dashboard from "./Pages/Dashboard.jsx";
import UsageHistory from "./Pages/UsageHistory.jsx";
import CreateUsageHistory from "./Pages/CreateUsageHistory.jsx";
import Register from "./Pages/Register.jsx";
import VerifyEmail from "./Pages/VerifyEmail.jsx";
import Login from "./Pages/Login.jsx";

const HideableHeaderNav = () => {
  const location = useLocation();

  const shouldHideHeaderNav = () => {
    return location.pathname === "/login" || location.pathname === "/register";
  };

  return (
    <HeaderNav className={shouldHideHeaderNav() ? "hide-header-nav" : ""} />
  );
};
const App = () => {
  return (
    <Router>
      <div>
        <Header />
        {/* <div className="headernav_container">
         
        </div> */}
        <HeaderNav />;{/* <Department/> */}
        {/* // code within rooute page should be change */}
        <Routes>
          <Route path="/department" element={<Departmment />} />
          <Route path="/equipmentPage" element={<EquipmentPage />} />
          <Route path="/MpPage" element={<MpPage />} />
          <Route path="/administration" element={<Administration />} />
          <Route path="/createequipment" element={<CreateEquipment />} />
          <Route path="/equipmentDetail" element={<EquipmentDetail />} />
          <Route path="/usageHistory" element={<UsageHistory />} />
          <Route path="/createUsageHistory" element={<CreateUsageHistory />} />
          <Route path="/register" element={<Register />} />
          <Route path="/login" element={<Login />} />
          <Route path="/Dashboard" element={<Dashboard />} />
          <Route path="/verifyemail" element={<VerifyEmail />} />

          {/* <Route path="/" element={<Home/>}/> */}
        </Routes>
      </div>
    </Router>
  );
};

export default App;
