import React, { useEffect, useState } from "react";
import { useParams, useLocation } from "react-router-dom";
import axios from "axios";

const EquipmentDetail = () => {
  const { id } = useParams();
  const [equipmentDetail, setEquipmentDetail] = useState(null);
  const location = useLocation();
  const queryParams = new URLSearchParams(location.search);
  const rowId = queryParams.get("id");

  useEffect(() => {
    // Fetch detailed information using the ID and make the request to another URL
    axios
      .get(`https://localhost:7066/api/Equipment`, {
        params: { id: rowId }, // Pass id as a query parameter
      })
      .then((response) => {
        // Set the equipment detail data in state
        setEquipmentDetail(response.data);
        console.log(response.data);
      })
      .catch((error) => {
        console.error("Error fetching equipment detail:", error);
      });
  }, [id]);

  return (
    <div className="equipment-detail-container">
      <div className="equipment-info">
        <h2>Equipment Information</h2>
        {/* Display equipment information here */}
        {equipmentDetail && (
          <div>
            <p>Name: {equipmentDetail.name}</p>
            <p>Description: {equipmentDetail.description}</p>
            {/* ...other fields */}
          </div>
        )}
      </div>
      <div className="list-info">
        <div>
          <h2>Usage History</h2>
          {/* Display usage history list here */}
          {/* ... */}
        </div>
        <div>
          <h2>Maintenance Plans</h2>
          {/* Display maintenance plans list here */}
          {/* ... */}
        </div>
        {/* Add more list sections as needed */}
      </div>
    </div>
  );
};

export default EquipmentDetail;
