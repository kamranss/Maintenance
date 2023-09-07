import React, { useState } from "react";

const EmailVerification = () => {
  const [otp, setOtp] = useState("");

  const handleOtpChange = (e) => {
    setOtp(e.target.value);
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    // Handle OTP verification logic here
  };

  return (
    <div className="verification-container">
      <div className="verification-box">
        <h2>Email Verification</h2>
        <p>Enter the OTP you received by email.</p>
        <form onSubmit={handleSubmit}>
          <input
            type="text"
            placeholder="Enter OTP"
            value={otp}
            onChange={handleOtpChange}
          />
          <button type="submit" className="verify-button">
            Verify
          </button>
        </form>
      </div>
    </div>
  );
};

export default EmailVerification;
