﻿using UnityEngine;
using System.Collections;
	
namespace ProBuilder2.VR
{
	/**
	 * Singleton for playing audio clips in VR editor.
	 */
	public class VRAudioModule : MonoBehaviour
	{
		[SerializeField] private AudioSource m_AudioSource = null;

		void Start()
		{
			if(m_AudioSource == null)
				m_AudioSource = gameObject.AddComponent<AudioSource>();
		}

		public void Play(AudioClip clip)
		{
			m_AudioSource.clip = clip;
			m_AudioSource.Play();
		}
	}
}
