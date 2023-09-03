import React, { useEffect, useState } from "react";
import axios from "axios";
import Swal from "sweetalert2";
import withReactContent from "sweetalert2-react-content";
// import FormInputYear from "../FormFields/FormInputYear";
// import { FormControl, FormGroup, FormLabel } from "react-bootstrap";

// import { FormControl, FormGroup, FormLabel, Button } from "@mui/material";
// import { makeStyles } from "@mui/styles";
// import "bootstrap/dist/css/bootstrap.min.css";
import {
  FormControl,
  FormGroup,
  FormLabel,
  Button,
  TextField,
  Select,
  MenuItem,
  // InputLabel,
  styled,
  // ThemeProvider,
  createTheme,
  Autocomplete,
  debounce,
  Popper,
} from "@mui/material";
// import { styled } from "@mui/material/styles";

const FormCreateEquipment = () => {
  // const [enteredName, setEnteredName] = useState("");

  const [models, setModels] = useState([]); // State to hold fetched models
  const [selectedModel, setSelectedModel] = useState(null);
  const [selectedModelId, setSelectedModelId] = useState(""); // State to hold selected model ID
  const [searchQuery, setSearchQuery] = useState(""); // State to hold search query

  const [Types, setTypes] = useState([]);
  const [selectedType, setSelectedType] = useState(null);
  const [selectedTypelId, setSelectedTypeId] = useState(""); // State to hold selected model ID
  const [searchQueryfortypes, setSearchQueryfortypes] = useState(""); // State to hold search query

  const [Departments, setDepartments] = useState([]);
  const [selectedDepartments, setSelectedDepartments] = useState(null);
  const [selectedDepartmentsId, setSelectedDepartmentsId] = useState(""); // State to hold selected model ID
  const [searchQueryforDepartments, setSearchQueryforDepartments] =
    useState(""); // State to hold search query

  const [UsageLocations, setUsageLocations] = useState([]);
  const [selectedUsageLocations, setSelectedUsageLocations] = useState(null);
  const [selectedUsageLocationsId, setSelectedUsageLocationsId] = useState(""); // State to hold selected model ID
  const [searchQueryforUsageLocations, setSearchQueryforUsageLocations] =
    useState("");

  const [Manufactures, setManufactures] = useState([]);
  const [selectedManufacture, setSelectedManufactures] = useState(null);
  const [selectedManufacturesId, setSelectedManufactureId] = useState(""); // State to hold selected model ID
  const [searchQueryforManufactures, setSearchQueryforManufactures] =
    useState("");

  const [OperationSite, setOperationSite] = useState([]);
  const [selectedOperationSite, setSelectedOperationSite] = useState(null);
  const [selectedOperationSiteId, setSelectedOperationSiteId] = useState(""); // State to hold selected model ID
  const [searchQueryforOperationSite, setSearchQueryforOperationSite] =
    useState("");

  const MySwal = withReactContent(Swal);
  const [validationErrors, setValidationErrors] = useState({});
  const [isSubmitted, setIsSubmitted] = useState(false);

  const [formDataa, setFormData] = useState({}); // State to hold form data

  // const [filteredModels, setFilteredModels] = useState([]); // State to hold filtered models
  const theme = createTheme();

  // const CustomPopper = React.forwardRef(function CustomPopper(props, ref) {
  //   return (
  //     <Popper
  //       {...props}
  //       placement="bottom-start" // Adjust the placement as needed
  //       modifiers={[
  //         {
  //           name: "offset",
  //           options: {
  //             offset: [0, 8], // Adjust the offset to position the dropdown
  //           },
  //         },
  //       ]}
  //       ref={ref}
  //     />
  //   );
  // });

  // useEffect(() => {
  //   // Fetch models from the API when the component mounts
  //   fetchModels(searchQuery);
  // }, [searchQuery]);

  const useStyles = styled((theme) => ({
    select: {
      width: "100%", // Adjust the width as needed
      "& .MuiSelect-select.MuiSelect-select": {
        paddingBottom: theme.spacing(1), // Adds spacing below the dropdown icon
      },
    },
  }));

  const fetchModels = async (name) => {
    try {
      const params = new URLSearchParams({
        name: name, // Use the search query as the 'name' parameter
      });

      const url = `https://localhost:7066/api/Model/DropDown?${params}`;
      const response = await axios.get(url);
      console.log("API response:", response.data); // Log the API response

      if (response.data && Array.isArray(response.data)) {
        console.log("Fetched models:", response.data); // Log the fetched models
        setModels(response.data);
      } else {
        console.error(
          "API response does not contain an array of models:",
          response.data
        );
      }
    } catch (error) {
      console.error("Error:", error);
    }
  };

  const fetchTypes = async (name) => {
    try {
      const params = new URLSearchParams({
        name: name, // Use the search query as the 'name' parameter
      });

      const url = `https://localhost:7066/api/EquipmentType/DropDown?${params}`;
      const response = await axios.get(url);
      console.log("API response:", response.data); // Log the API response

      if (response.data && Array.isArray(response.data)) {
        console.log("Fetched models:", response.data); // Log the fetched models
        setTypes(response.data);
      } else {
        console.error(
          "API response does not contain an array of models:",
          response.data
        );
      }
    } catch (error) {
      console.error("Error:", error);
    }
  };

  const fetchDepartments = async (name) => {
    try {
      const params = new URLSearchParams({
        name: name, // Use the search query as the 'name' parameter
      });

      const url = `https://localhost:7066/api/Department/DropDown?${params}`;
      const response = await axios.get(url);
      console.log("API response:", response.data); // Log the API response

      if (response.data && Array.isArray(response.data)) {
        console.log("Fetched models:", response.data); // Log the fetched models
        setDepartments(response.data);
      } else {
        console.error(
          "API response does not contain an array of models:",
          response.data
        );
      }
    } catch (error) {
      console.error("Error:", error);
    }
  };

  const fetchModelsDebounced = debounce(fetchModels, 300);
  useEffect(() => {
    // Fetch models from the API when the component mounts or searchQuery changes
    fetchModels(searchQuery);
  }, [searchQuery]);

  const fetchTypesDebounced = debounce(fetchTypes, 300);
  useEffect(() => {
    fetchTypes(searchQueryfortypes);
  }, [searchQueryfortypes]);

  const fetchDepartmentsDebounced = debounce(fetchDepartments, 300);
  useEffect(() => {
    fetchDepartments(searchQueryforDepartments);
  }, [searchQueryforDepartments]);

  const submitForm = async (e) => {
    e.preventDefault();
    setValidationErrors({});
    try {
      const formData = new FormData(); // Create a new FormData object

      formData.append("Name", formDataa.Name || "");
      formData.append("UnitNumber", formDataa.UnitNumber || "");
      formData.append(
        "Description",
        JSON.stringify(formDataa.Description || "")
      );
      formData.append(
        "Identification",
        JSON.stringify(formDataa.Identification || "")
      );
      formData.append(
        "OperationSiteid",
        selectedOperationSite ? selectedOperationSite.id : ""
      );
      formData.append(
        "ManufactureId",
        selectedManufacture ? selectedManufacture.id : ""
      );
      formData.append("ProductionYear", formDataa.ProductionYear || "");
      formData.append("SerialNumber", formDataa.SerialNumber || "");
      formData.append("Capacity", formDataa.Capacity || "");
      // formData.append(
      //   "EquipmentTypeId",
      //   JSON.stringify(selectedType ? selectedType.id : null)
      // );
      formData.append(
        "DepartmentId",
        selectedDepartments ? selectedDepartments.id : ""
      );
      formData.append("EquipmentTypeId", selectedType ? selectedType.id : "");
      // formData.append(
      //   "UsageLocation",
      //   selectedUsageLocations ? selectedUsageLocations.label : ""
      // );
      formData.append(
        "DepartmentId",
        selectedDepartments ? selectedDepartments.id : ""
      );
      formData.append("ModelId", selectedModel ? selectedModel.id : "");
      if (formDataa.Image instanceof File) {
        formData.append("Image", formDataa.Image);
      }
      console.log(formDataa.Image);
      formData.append("LastMaintenaceDate", formDataa.LastMaintenaceDate || "");
      formData.append("CurrentValue", formDataa.CurrentValue || "");
      console.log(selectedUsageLocationsId);
      console.log(selectedUsageLocations);
      console.log("Form Data - Name:", formDataa.Name);
      console.log("Form Data - UnitNumber:", formDataa.UnitNumber);
      console.log("Form Data - Description:", formDataa.Description);
      console.log("Form Data - Image:", formDataa.Image);
      formData.append(
        "UsageLocation",
        selectedUsageLocations ? selectedUsageLocations : ""
      );

      const response = await fetch(
        "https://localhost:7066/api/Equipment/NewEquipment",
        {
          method: "POST",
          body: JSON.stringify(formData), // Use the FormData object as the request body
        }
      );
      console.log("Form Data - Name:", formDataa.Name);
      console.log("Form Data - UnitNumber:", formDataa.UnitNumber);
      console.log("Form Data - Description:", formDataa.Description);
      console.log("Form Data - Image:", formDataa.Image);
      for (const entry of formData.entries()) {
        console.log(entry);
      }

      if (response.ok) {
        MySwal.fire({
          icon: "success",
          title: "Success!",
          text: "Equipment created successfully.",
        }).then(() => {
          window.location.href = "/EquipmentPage";
          setIsSubmitted(true);
        });
        console.log("Equipment created successfully.");
        console.log(formData);
        setValidationErrors({});
      } else if (response.status === 400) {
        // Bad request with validation errors
        const errorData = await response.json();
        console.log("Validation errors:", errorData);

        // Update the state with the validation errors
        setValidationErrors(errorData.errors);
      } else {
        const errorMessage = await response.text();
        console.error("Error:", errorMessage);
      }
    } catch (error) {
      console.error("Error:", error);
    }
  };

  const handleInputChange = (fieldName, value) => {
    // Reset validation error for the specific field when the user starts typing
    setValidationErrors((prevErrors) => ({
      ...prevErrors,
      [fieldName]: [],
    }));

    // Update formData state
    setFormData((prevData) => ({
      ...prevData,
      [fieldName]: value,
    }));
  };
  const classes = useStyles();

  return (
    <>
      <form className="FormMain" onSubmit={submitForm}>
        <h2 className="heading">Create Usage History</h2>
        <div className="FormContainer">
          <div className="FormLeftSide">
            {/* <h2>Identification</h2> */}
            <div>
              <FormGroup className="mb-3">
                <FormLabel>Equipment Name</FormLabel>
                <TextField
                  type="text"
                  name="Name"
                  onChange={(e) => handleInputChange("Name", e.target.value)}
                />
                {validationErrors.Name && validationErrors.Name.length > 0 ? (
                  <span className="validation-error">
                    {validationErrors.Name[0]}
                  </span>
                ) : null}
              </FormGroup>
              <FormGroup className="mb-3">
                <FormLabel>Unit Number</FormLabel>
                <TextField
                  type="number"
                  name="UnitNumber"
                  onChange={(e) =>
                    handleInputChange("UnitNumber", e.target.value)
                  }
                />
                {validationErrors.UnitNumber &&
                validationErrors.UnitNumber.length > 0 ? (
                  <span className="validation-error">
                    {validationErrors.UnitNumber[0]}
                  </span>
                ) : null}
              </FormGroup>
              <FormGroup className="mb-3">
                <FormLabel>Description</FormLabel>
                <TextField
                  type="text"
                  name="Description"
                  onChange={(e) =>
                    handleInputChange("Description", e.target.value)
                  }
                />
                {/* {validationErrors.Description && (
                  <span className="validation-error">
                    {validationErrors.Description[0]}
                  </span>
                )} */}
                {validationErrors.Description &&
                validationErrors.Description.length > 0 ? (
                  <span className="validation-error">
                    {validationErrors.Description[0]}
                  </span>
                ) : null}
              </FormGroup>
              <FormGroup className="mb-3">
                <FormLabel>Identification</FormLabel>
                <TextField type="number" name="Identification" />
              </FormGroup>
              <FormGroup className="mb-3">
                <FormLabel>OperationSite</FormLabel>
                <Autocomplete
                  id="operationSite-autocomplete"
                  options={OperationSite}
                  getOptionLabel={(operationSite) => operationSite.name}
                  value={selectedOperationSite} // Bind selectedModelId to the Autocomplete value
                  onChange={(event, newValue) => {
                    setSelectedOperationSite(newValue); // Update selectedModel when a model is selected
                  }}
                  onInputChange={(event, newInputValue) => {
                    setSearchQueryforOperationSite(newInputValue); // Update searchQuery as input changes
                  }}
                  inputValue={searchQueryforOperationSite}
                  renderInput={(params) => (
                    <TextField
                      {...params}
                      label="Search or Select Operation Sites"
                      variant="outlined"
                    />
                  )}
                  renderOption={(props, option) => (
                    <li {...props}>{option.name}</li>
                  )}
                  PopperProps={{
                    placement: "bottom-start", // Adjust the placement as needed
                    modifiers: [
                      {
                        name: "offset",
                        options: {
                          offset: [0, 8], // Adjust the offset to position the dropdown
                        },
                      },
                    ],
                  }}
                />
              </FormGroup>
              <FormGroup className="mb-3">
                <FormLabel>Manufacture</FormLabel>
                <Autocomplete
                  id="manufacture-autocomplete"
                  options={Manufactures}
                  getOptionLabel={(manufacture) => manufacture.name}
                  value={selectedManufacture} // Bind selectedModelId to the Autocomplete value
                  onChange={(event, newValue) => {
                    setSelectedManufactures(newValue); // Update selectedModel when a model is selected
                  }}
                  onInputChange={(event, newInputValue) => {
                    setSearchQueryforManufactures(newInputValue); // Update searchQuery as input changes
                  }}
                  inputValue={searchQueryforManufactures}
                  renderInput={(params) => (
                    <TextField
                      {...params}
                      label="Search or Select Manufactures"
                      variant="outlined"
                    />
                  )}
                  renderOption={(props, option) => (
                    <li {...props}>{option.name}</li>
                  )}
                  PopperProps={{
                    placement: "bottom-start", // Adjust the placement as needed
                    modifiers: [
                      {
                        name: "offset",
                        options: {
                          offset: [0, 8], // Adjust the offset to position the dropdown
                        },
                      },
                    ],
                  }}
                />
                {validationErrors.Manufactures &&
                validationErrors.Manufactures.length > 0 ? (
                  <span className="validation-error">
                    {validationErrors.Manufactures[0]}
                  </span>
                ) : null}
              </FormGroup>
            </div>
          </div>
        </div>
        <Button type="submit" variant="contained" color="primary">
          Create
        </Button>
      </form>
    </>
  );
};

export default FormCreateEquipment;
