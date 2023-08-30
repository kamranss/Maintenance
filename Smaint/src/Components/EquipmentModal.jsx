import React from "react";
import Modal from "@mui/material/Modal";
import { styled } from "@mui/material/styles"; // Import styled from @mui/material

// Define your styles using the styled() function
const ModalContainer = styled("div")({
  position: "absolute",
  width: 400,
  bgcolor: "background.paper",
  border: "2px solid #000",
  boxShadow: 24,
  p: 4,
  top: "50%",
  left: "50%",
  transform: "translate(-50%, -50%)",
});

const EquipmentModal = ({ isOpen, handleClose, modalData }) => {
  return (
    <Modal open={isOpen} onClose={handleClose}>
      {/* Use your custom styled component */}
      <ModalContainer>
        <div>jdldjljl</div>
        {/* Render your modal content using the modalData */}
        {modalData && (
          <div>
            {/* <p>ID: {modalData.id}</p>
            <p>Name: {modalData.name}</p> */}
            {/* Other fields */}
          </div>
        )}
        <button onClick={handleClose}>Close</button>
      </ModalContainer>
    </Modal>
  );
};

export default EquipmentModal;
