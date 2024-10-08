using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.CoreAudioApi;
using NAudio.Dsp;

namespace Equalizer
{
    // Performs live equalisation of sound playing through computer speakers
    public class LiveEQ
    {
        private WasapiLoopbackCapture _audioCapture;
        private BufferedWaveProvider _bufferedWaveProvider;
        private IWavePlayer _outputDevice;

        // Variables for Bass and Treble levels
        private float bassLevel;
        private float trebleLevel;

     public void AudioOutputProcessor()
        {
            InitializeAudioCapture();
        }

    private void InitializeAudioCapture()
        {
            // Capturing the audio output via WASAPI Loopback (for the default device)
            _audioCapture = new WasapiLoopbackCapture();
            _audioCapture.DataAvailable += OnAudioDataAvailable;

            // Set up a buffered wave provider for further audio processing
            _bufferedWaveProvider = new BufferedWaveProvider(_audioCapture.WaveFormat);

            // Output to the default output device
            _outputDevice = new WaveOutEvent();
            _outputDevice.Init(_bufferedWaveProvider);
            _audioCapture.StartRecording();
            _outputDevice.Play();
        }

    private void OnAudioDataAvailable(object sender, WaveInEventArgs e)
        {
            // Retrieve audio data as byte array
            byte[] audioData = e.Buffer;
            int bytesRecorded = e.BytesRecorded;

            // Apply Bass and Treble adjustments to the audio data
            AdjustBassAndTreble(audioData, bytesRecorded);

            // Feed the processed audio back to the output device
            _bufferedWaveProvider.AddSamples(audioData, 0, bytesRecorded);
        }

    private void AdjustBassAndTreble(byte[] audioData, int bytesRecorded)
        {
            // Convert byte array to floating point samples (for DSP)
            int sampleCount = bytesRecorded / 4; // 32-bit float = 4 bytes
            float[] floatBuffer = new float[sampleCount];
            Buffer.BlockCopy(audioData, 0, floatBuffer, 0, bytesRecorded);

            for (int i = 0; i < sampleCount; i++)
            {
                float sample = floatBuffer[i];

                // Placeholder for actual Bass and Treble adjustment logic
                // You can apply filtering (low-pass for bass, high-pass for treble) here

                // Example: Simple volume adjustment (can be replaced with actual DSP)
                sample *= bassLevel;  // Adjust bass
                sample *= trebleLevel;  // Adjust treble

                // Store the adjusted sample back
                floatBuffer[i] = sample;
            }

            // Convert the float buffer back to byte array
            Buffer.BlockCopy(floatBuffer, 0, audioData, 0, bytesRecorded);
        }

    public void SetBassLevel(float level)
        {
            // Level should be between 0.0 (no bass) and 1.0 (full bass)
            bassLevel = level;
        }

    public void SetTrebleLevel(float level)
        {
            // Level should be between 0.0 (no treble) and 1.0 (full treble)
            trebleLevel = level;
        }

    public void StopProcessing()
        {
            _audioCapture.StopRecording();
            _outputDevice.Stop();
            _audioCapture.Dispose();
            _outputDevice.Dispose();
        }

    }
}
