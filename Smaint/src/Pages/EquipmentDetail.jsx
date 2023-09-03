import { useParams, useLocation } from "react-router-dom";
import React, { useEffect, useState } from "react";
import axios from "axios";
import { useTable, usePagination } from "react-table";
import { fileBaseUrl } from "../Contants/Urls"; // Adjust the path accordingly

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
        console.log(response.data.imagUrl);
      })
      .catch((error) => {
        console.error("Error fetching equipment detail:", error);
      });
  }, [id]);

  const imageUrl =
    equipmentDetail && equipmentDetail.imagUrl
      ? fileBaseUrl + equipmentDetail.imagUrl
      : null;
  console.log(imageUrl);

  return (
    <div className="equipment-detail-container">
      <div className="equipment-info">
        <div className="heading">
          <h2>Equipment Information</h2>
        </div>

        {equipmentDetail && (
          <div className="equipment-info-box">
            <div className="info-field">
              <p className="info-label">Name:</p>
              <p className="info-value">{equipmentDetail.name}</p>
            </div>
            <div className="info-field">
              <p className="info-label">Description:</p>
              <p className="info-value">{equipmentDetail.description}</p>
            </div>
            <div className="info-field">
              <p className="info-label">Department:</p>
              <p className="info-value">{equipmentDetail.department}</p>
            </div>
            <div className="info-field">
              <p className="info-label">Manufacture:</p>
              <p className="info-value">{equipmentDetail.manufacture}</p>
            </div>
            <div className="info-field">
              <p className="info-label">Model:</p>
              <p className="info-value">{equipmentDetail.model}</p>
            </div>
            <div className="info-field">
              <p className="info-label">OperationSite:</p>
              <p className="info-value">{equipmentDetail.operationSite}</p>
            </div>
            {/* Add more fields as needed */}
          </div>
        )}
      </div>
      <div className="list-info">
        <div className="image_Container">
          {/* {equipmentDetail && ( */}
          <div className="image_Box">
            {imageUrl ? (
              <img src={imageUrl} alt="" />
            ) : (
              <p>No image available</p>
            )}
          </div>
          {/* )} */}
        </div>
      </div>
    </div>
  );
};

export default EquipmentDetail;
