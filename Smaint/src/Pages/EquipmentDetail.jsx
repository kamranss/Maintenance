import { useParams, useLocation } from "react-router-dom";
import React, { useEffect, useState } from "react";
import axios from "axios";
import { useTable, usePagination } from "react-table";
import { fileBaseUrl } from "../Contants/Urls"; // Adjust the path accordingly
import { CircularProgress } from "@mui/material";
import EquipmentStatusChangemodal from "../Components/Modals/EquipmentStatusChangemodal";

const EquipmentDetail = () => {
  const { id } = useParams();
  const [equipmentDetail, setEquipmentDetail] = useState(null);
  const location = useLocation();
  const queryParams = new URLSearchParams(location.search);
  const rowId = queryParams.get("id");

  const [isLoading, setIsLoading] = useState(true);

  const [isModalOpen, setIsModalOpen] = useState(false);
  const [equipmentIdForStatusChange, setEquipmentIdForStatusChange] =
    useState(null);

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
        setIsLoading(false);
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

  const handleStatusChange = (equipmentId) => {
    // Open the modal and set the equipment ID
    setIsModalOpen(true);
    setEquipmentIdForStatusChange(equipmentId);
  };

  const handleSetMpComplete = () => {};

  const handleSetResetValue = () => {};

  const handlePartChange = () => {};

  const handleAddPartChange = () => {};

  const handleDeleteChange = () => {};

  if (isLoading) {
    return (
      <div className="spinner-container">
        <CircularProgress />
      </div>
    );
  }
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
              <p className="info-label">Type:</p>
              <p className="info-value">{equipmentDetail.type}</p>
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
      {equipmentDetail && (
        <div className="equipment-info-box_Status">
          <div className="info-field">
            {/* <p className="info-label">Status:</p> */}
            <p
              className={`info-valueee ${
                equipmentDetail.status === "ACTIVE"
                  ? "row-active"
                  : equipmentDetail.status === "INACTIVE"
                  ? "row-inactive"
                  : equipmentDetail.status === "REPAIR"
                  ? "row-repair"
                  : equipmentDetail.status === "IN_USE"
                  ? "row-inuse"
                  : ""
              }`}
            >
              {equipmentDetail.status}
            </p>
          </div>
          <div className="button_container">
            <div className="equ_page_action-buttons_changestatus">
              <button onClick={handleStatusChange}>Change Status</button>
            </div>
            <EquipmentStatusChangemodal
              isOpen={isModalOpen}
              onClose={() => setIsModalOpen(false)}
              equipmentId={equipmentIdForStatusChange}
            />
            <div className="equ_page_action-buttons_addPart">
              <button onClick={handleAddPartChange}>Add Part</button>
            </div>
            <div className="equ_page_action-buttons_addMp">
              <button onClick={handleStatusChange}>Add Mp</button>
            </div>
            <div className="equ_page_action-buttons_delete">
              <button onClick={handleDeleteChange}>Delete</button>
            </div>
          </div>

          {equipmentDetail && (
            <div className="equipment-info-box_2">
              <div className="info-field">
                <p className="info-label">Current Value:</p>
                <p className="info-value">{equipmentDetail.currentValue}</p>
              </div>
              <div className="info-field">
                <p className="info-label">Squence Value:</p>
                <p className="info-value">{equipmentDetail.squenceValue}</p>
              </div>
              <div className="info-field">
                <p className="info-label">Reset Value:</p>
                <p className="info-value">{equipmentDetail.resetValue}</p>
              </div>
            </div>
          )}

          <div className="equ_page_action-buttons_resetValue">
            <button onClick={handleSetResetValue}>Set Reset Value</button>
          </div>
          <div className="equ_page_action-buttons_setMp">
            <button onClick={handleSetMpComplete}>Set Mp Complete</button>
          </div>
        </div>
      )}

      <div className="list-info">
        <div className="image_Main">
          {/* {equipmentDetail && ( */}
          <div className="image_Container">
            {imageUrl ? (
              <div className="image_box">
                <img src={imageUrl} alt="" />
              </div>
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
